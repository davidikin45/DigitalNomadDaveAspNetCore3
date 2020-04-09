using System.IO;
using System.Security.Cryptography;


//https://github.com/jrnker/CSharp-easy-RSA-PEM
//Encryption = Encrypt with public, decrypt with private
//Signature = Encrypt with private, decrypt with public
namespace DND.IDP.Cryptography
{
    public class AsymmetricEncryptionHelper
    {
        //Public key is generally .pub
        //Private key is generally .key
        public static class RsaWithPEMKey
        {
            public static void AssignNewKey(string publicKeyPath, string privateKeyPath)
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

                    File.WriteAllText(publicKeyPath, Crypto.ExportPublicKeyToX509PEM(rsa));
                    File.WriteAllText(privateKeyPath, Crypto.ExportPrivateKeyToRSAPEM(rsa));
                }
            }

            public static RSAParameters GetPublicKeyRSAParameters(string publicKeyPath)
            {
                using (var rsa = Crypto.DecodeX509PublicKey(File.ReadAllText(publicKeyPath)))
                {
                    return rsa.ExportParameters(false);
                }
            }

            public static RSAParameters GetPrivateKeyRSAParameters(string privateKeyPath)
            {
                using (var rsa = Crypto.DecodeRsaPrivateKey(File.ReadAllText(privateKeyPath)))
                {
                    return rsa.ExportParameters(true);
                }
            }

            public static byte[] EncryptData(string publicKeyPath, byte[] dataToEncrypt)
            {
                byte[] cipherbytes;

                using (var rsa = Crypto.DecodeX509PublicKey(File.ReadAllText(publicKeyPath)))
                {

                    cipherbytes = rsa.Encrypt(dataToEncrypt, false);
                }

                return cipherbytes;
            }

            public static byte[] DecryptData(string privateKeyPath, byte[] dataToEncrypt)
            {
                byte[] plain;

                using (var rsa = Crypto.DecodeRsaPrivateKey(File.ReadAllText(privateKeyPath)))
                {
                    plain = rsa.Decrypt(dataToEncrypt, false);
                }

                return plain;
            }

            public static byte[] CreateDigitalSignature(string privateKeyPath, byte[] hashOfDataToSign)
            {
                using (var rsa = Crypto.DecodeRsaPrivateKey(File.ReadAllText(privateKeyPath)))
                {

                    var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                    rsaFormatter.SetHashAlgorithm("SHA256");

                    return rsaFormatter.CreateSignature(hashOfDataToSign);
                }
            }

            public static bool VerifySignature(string publicKeyPath, byte[] hashOfDataToSign, byte[] signature)
            {
                using (var rsa = Crypto.DecodeX509PublicKey(File.ReadAllText(publicKeyPath)))
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
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.PersistKeyInCsp = false;

                    var publicKey = Crypto.ExportPublicKeyToX509PEM(rsa);
                    var privateKey = Crypto.ExportPrivateKeyToRSAPEM(rsa);

                    return (publicKey: publicKey, privateKey: privateKey);
                }
            }

            public static RSAParameters GetPublicKeyRSAParameters(string publicKeyString)
            {
                using (var rsa = Crypto.DecodeX509PublicKey(publicKeyString))
                {
                    return rsa.ExportParameters(false);
                }
            }

            public static RSAParameters GetPrivateKeyRSAParameters(string privateKeyString)
            {
                using (var rsa = Crypto.DecodeRsaPrivateKey(privateKeyString))
                {
                    return rsa.ExportParameters(true);
                }
            }

            public static byte[] EncryptData(string publicKeyString, byte[] dataToEncrypt)
            {
                byte[] cipherbytes;

                using (var rsa = Crypto.DecodeX509PublicKey(publicKeyString))
                {

                    cipherbytes = rsa.Encrypt(dataToEncrypt, false);
                }

                return cipherbytes;
            }

            public static byte[] DecryptData(string privateKeyString, byte[] dataToEncrypt)
            {
                byte[] plain;

                using (var rsa = Crypto.DecodeRsaPrivateKey(privateKeyString))
                {
                    plain = rsa.Decrypt(dataToEncrypt, false);
                }

                return plain;
            }

            public static byte[] CreateDigitalSignature(string privateKeyString, byte[] hashOfDataToSign)
            {
                using (var rsa = Crypto.DecodeRsaPrivateKey(privateKeyString))
                {

                    var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                    rsaFormatter.SetHashAlgorithm("SHA256");

                    return rsaFormatter.CreateSignature(hashOfDataToSign);
                }
            }

            public static bool VerifySignature(string publicKeyString, byte[] hashOfDataToSign, byte[] signature)
            {
                using (var rsa = Crypto.DecodeX509PublicKey(publicKeyString))
                {
                    var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                    rsaDeformatter.SetHashAlgorithm("SHA256");

                    return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
                }
            }
        }
    }
}
