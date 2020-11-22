using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AspNetCore.Mvc.Extensions.Security
{
    public class AsymmetricEncryptionHelper
    {
        public class RSANew
        {
            private RSA rsa;

            public RSANew()
            {
                rsa = RSA.Create(2048);
            }

            public byte[] Encrypt(string dataToEncrypt)
            {
                return rsa.Encrypt(Encoding.UTF8.GetBytes(dataToEncrypt), RSAEncryptionPadding.OaepSHA256);
            }

            public byte[] Encrypt(byte[] dataToEncrypt)
            {
                return rsa.Encrypt(dataToEncrypt, RSAEncryptionPadding.OaepSHA256);
            }

            public byte[] Decrypt(byte[] dataToDecrypt)
            {
                return rsa.Decrypt(dataToDecrypt, RSAEncryptionPadding.OaepSHA256);
            }

            public byte[] ExportPrivateKey(string password, int numberOfIterations = 100000)
            {
                byte[] encryptedPrivateKey = new byte[2000];

                PbeParameters keyParams = new PbeParameters(PbeEncryptionAlgorithm.Aes256Cbc, HashAlgorithmName.SHA256, numberOfIterations);
                encryptedPrivateKey = rsa.ExportEncryptedPkcs8PrivateKey(Encoding.UTF8.GetBytes(password), keyParams);

                return encryptedPrivateKey;
            }

            public void ImportEncryptedPrivateKey(byte[] encryptedKey, string password)
            {
                rsa.ImportEncryptedPkcs8PrivateKey(Encoding.UTF8.GetBytes(password), encryptedKey, out _);
            }

            public byte[] ExportPublicKey()
            {
                return rsa.ExportRSAPublicKey();
            }

            public void ImportPublicKey(byte[] publicKey)
            {
                rsa.ImportRSAPublicKey(publicKey, out _);
            }
        }

        public class RsaWithCspKey
        {
            const string ContainerName = "MyContainer";

            public void AssignNewKey()
            {
                CspParameters cspParams = new CspParameters(1);
                cspParams.KeyContainerName = ContainerName;
                cspParams.Flags = CspProviderFlags.UseMachineKeyStore;
                cspParams.ProviderName = "Microsoft Strong Cryptographic Provider";

                var rsa = new RSACryptoServiceProvider(cspParams) { PersistKeyInCsp = true };
            }

            public void DeleteKeyInCsp()
            {
                var cspParams = new CspParameters { KeyContainerName = ContainerName };
                var rsa = new RSACryptoServiceProvider(cspParams) { PersistKeyInCsp = false };

                rsa.Clear();
            }

            public byte[] EncryptData(byte[] dataToEncrypt)
            {
                byte[] cipherbytes;

                var cspParams = new CspParameters { KeyContainerName = ContainerName };

                using (var rsa = new RSACryptoServiceProvider(2048, cspParams))
                {
                    cipherbytes = rsa.Encrypt(dataToEncrypt, false);
                }

                return cipherbytes;
            }

            public byte[] DecryptData(byte[] dataToDecrypt)
            {
                byte[] plain;

                var cspParams = new CspParameters { KeyContainerName = ContainerName };

                using (var rsa = new RSACryptoServiceProvider(2048, cspParams))
                {
                    plain = rsa.Decrypt(dataToDecrypt, false);
                }

                return plain;
            }

            public static byte[] CreateDigitalSignature(byte[] hashOfDataToSign)
            {
                var cspParams = new CspParameters { KeyContainerName = ContainerName };

                using (var rsa = new RSACryptoServiceProvider(2048, cspParams))
                {

                    var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                    rsaFormatter.SetHashAlgorithm("SHA256");

                    return rsaFormatter.CreateSignature(hashOfDataToSign);
                }
            }

            public static bool VerifySignature(byte[] hashOfDataToSign, byte[] signature)
            {
                var cspParams = new CspParameters { KeyContainerName = ContainerName };

                using (var rsa = new RSACryptoServiceProvider(2048, cspParams))
                {

                    var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                    rsaDeformatter.SetHashAlgorithm("SHA256");

                    return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
                }
            }
        }

        public class RsaWithRsaParameterKey
        {
            private RSAParameters _publicKey;
            private RSAParameters _privateKey;

            public void AssignNewKey()
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;
                    _publicKey = rsa.ExportParameters(false);
                    _privateKey = rsa.ExportParameters(true);
                }
            }

            public byte[] EncryptData(byte[] dataToEncrypt)
            {
                byte[] cipherbytes;

                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;
                    rsa.ImportParameters(_publicKey);

                    cipherbytes = rsa.Encrypt(dataToEncrypt, true);
                }

                return cipherbytes;
            }

            public byte[] DecryptData(byte[] dataToEncrypt)
            {
                byte[] plain;

                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;

                    rsa.ImportParameters(_privateKey);
                    plain = rsa.Decrypt(dataToEncrypt, true);
                }

                return plain;
            }

            public byte[] CreateDigitalSignature(byte[] hashOfDataToSign)
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;

                    rsa.ImportParameters(_privateKey);

                    var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                    rsaFormatter.SetHashAlgorithm("SHA256");

                    return rsaFormatter.CreateSignature(hashOfDataToSign);
                }
            }

            public bool VerifySignature(byte[] hashOfDataToSign, byte[] signature)
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.ImportParameters(_publicKey);

                    var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                    rsaDeformatter.SetHashAlgorithm("SHA256");

                    return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
                }
            }
        }

        public class RsaWithXmlKey
        {
            public void AssignNewKey(string publicKeyPath, string privateKeyPath)
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;

                    if (File.Exists(privateKeyPath))
                    {
                        File.Delete(privateKeyPath);
                    }

                    if (File.Exists(publicKeyPath))
                    {
                        File.Delete(publicKeyPath);
                    }

                    var publicKeyfolder = Path.GetDirectoryName(publicKeyPath);
                    var privateKeyfolder = Path.GetDirectoryName(privateKeyPath);

                    if (!Directory.Exists(publicKeyfolder))
                    {
                        Directory.CreateDirectory(publicKeyfolder);
                    }

                    if (!Directory.Exists(privateKeyfolder))
                    {
                        Directory.CreateDirectory(privateKeyfolder);
                    }

                    File.WriteAllText(publicKeyPath, rsa.ToXmlString(false));
                    File.WriteAllText(privateKeyPath, rsa.ToXmlString(true));
                }
            }

            public byte[] EncryptData(string publicKeyPath, byte[] dataToEncrypt)
            {
                byte[] cipherbytes;

                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;
                    rsa.FromXmlString(File.ReadAllText(publicKeyPath));

                    cipherbytes = rsa.Encrypt(dataToEncrypt, false);
                }

                return cipherbytes;
            }

            public byte[] DecryptData(string privateKeyPath, byte[] dataToEncrypt)
            {
                byte[] plain;

                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;
                    rsa.FromXmlString(File.ReadAllText(privateKeyPath));
                    plain = rsa.Decrypt(dataToEncrypt, false);
                }

                return plain;
            }

            public static byte[] CreateDigitalSignature(string privateKeyPath, byte[] hashOfDataToSign)
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;

                    rsa.FromXmlString(File.ReadAllText(privateKeyPath));

                    var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                    rsaFormatter.SetHashAlgorithm("SHA256");

                    return rsaFormatter.CreateSignature(hashOfDataToSign);
                }
            }

            public static bool VerifySignature(string publicKeyPath, byte[] hashOfDataToSign, byte[] signature)
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.FromXmlString(File.ReadAllText(publicKeyPath));

                    var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                    rsaDeformatter.SetHashAlgorithm("SHA256");

                    return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
                }
            }
        }

        public static class RsaWithPEMKey
        {
            public static void AssignNewKey(string publicKeyPath, string privateKeyPath)
            {
                RSAPEMHelper.GenerateRsaKeyPairFiles(publicKeyPath, privateKeyPath);
            }

            public static RSAParameters GetPublicKeyRSAParameters(string publicKeyPath)
            {
                using (var rsa = RSAPEMHelper.PublicKeyFromPemFile(publicKeyPath))
                {
                    return rsa.ExportParameters(false);
                }
            }

            public static RSAParameters GetPrivateKeyRSAParameters(string privateKeyPath)
            {
                using (var rsa = RSAPEMHelper.PrivateKeyFromPemFile(privateKeyPath))
                {
                    return rsa.ExportParameters(true);
                }
            }

            public static byte[] EncryptData(string publicKeyPath, byte[] dataToEncrypt)
            {
                byte[] cipherbytes;

                using (var rsa = RSAPEMHelper.PublicKeyFromPemFile(publicKeyPath))
                {

                    cipherbytes = rsa.Encrypt(dataToEncrypt, false);
                }

                return cipherbytes;
            }

            public static byte[] DecryptData(string privateKeyPath, byte[] dataToEncrypt)
            {
                byte[] plain;

                using (var rsa = RSAPEMHelper.PrivateKeyFromPemFile(privateKeyPath))
                {
                    plain = rsa.Decrypt(dataToEncrypt, false);
                }

                return plain;
            }

            public static byte[] CreateDigitalSignature(string privateKeyPath, byte[] hashOfDataToSign)
            {
                using (var rsa = RSAPEMHelper.PrivateKeyFromPemFile(privateKeyPath))
                {

                    var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                    rsaFormatter.SetHashAlgorithm("SHA256");

                    return rsaFormatter.CreateSignature(hashOfDataToSign);
                }
            }

            public static bool VerifySignature(string publicKeyPath, byte[] hashOfDataToSign, byte[] signature)
            {
                using (var rsa = RSAPEMHelper.PublicKeyFromPemFile(publicKeyPath))
                {
                    var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                    rsaDeformatter.SetHashAlgorithm("SHA256");

                    return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
                }
            }
        }

        public static class RsaWithPEMKeyString
        {
            public static (string publicKey, string privateKey) AssignNewKey()
            {
                return RSAPEMHelper.GenerateRsaKeyPair();
            }

            public static RSAParameters GetPublicKeyRSAParameters(string publicKeyString)
            {
                using (var rsa = RSAPEMHelper.PublicKeyFromPem(publicKeyString))
                {
                    return rsa.ExportParameters(false);
                }
            }

            public static RSAParameters GetPrivateKeyRSAParameters(string privateKeyString)
            {
                using (var rsa = RSAPEMHelper.PrivateKeyFromPem(privateKeyString))
                {
                    return rsa.ExportParameters(true);
                }
            }

            public static byte[] EncryptData(string publicKeyString, byte[] dataToEncrypt)
            {
                byte[] cipherbytes;

                using (var rsa = RSAPEMHelper.PublicKeyFromPem(publicKeyString))
                {

                    cipherbytes = rsa.Encrypt(dataToEncrypt, false);
                }

                return cipherbytes;
            }

            public static byte[] DecryptData(string privateKeyString, byte[] dataToEncrypt)
            {
                byte[] plain;

                using (var rsa = RSAPEMHelper.PrivateKeyFromPem(privateKeyString))
                {
                    plain = rsa.Decrypt(dataToEncrypt, false);
                }

                return plain;
            }

            public static byte[] CreateDigitalSignature(string privateKeyString, byte[] hashOfDataToSign)
            {
                using (var rsa = RSAPEMHelper.PrivateKeyFromPem(privateKeyString))
                {

                    var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                    rsaFormatter.SetHashAlgorithm("SHA256");

                    return rsaFormatter.CreateSignature(hashOfDataToSign);
                }
            }

            public static bool VerifySignature(string publicKeyString, byte[] hashOfDataToSign, byte[] signature)
            {
                using (var rsa = RSAPEMHelper.PublicKeyFromPem(publicKeyString))
                {
                    var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                    rsaDeformatter.SetHashAlgorithm("SHA256");

                    return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
                }
            }
        }
    }
}
