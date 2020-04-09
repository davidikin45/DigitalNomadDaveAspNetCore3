using DND.IDP.Cryptography;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DND.IDP
{
    public static class SigningKey
    {
        //No kid or x5t
        public static SymmetricSecurityKey LoadSymmetricSecurityKey(string bearerTokenKey, string kidPrefix = "")
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(bearerTokenKey));
            key.KeyId = $"{kidPrefix}{HashData.ComputeHashSha256Base64String(bearerTokenKey)}";

            return key;
        }

        //No kid or x5t
        public static RsaSecurityKey LoadPrivateRsaSigningKey(string privateKeyPath, string kidPrefix = "")
        {
            var rsaParameters = AsymmetricEncryptionHelper.RsaWithPEMKey.GetPrivateKeyRSAParameters(privateKeyPath);
            var key = new RsaSecurityKey(rsaParameters);
            key.KeyId = $"{kidPrefix}{key.KeyId}";
            //key.KeyId = "IDP";
            return key;
        }

        //No kid or x5t
        public static RsaSecurityKey LoadPublicRsaSigningKey(string publicKeyPath, string kidPrefix = "")
        {
            var rsaParameters = AsymmetricEncryptionHelper.RsaWithPEMKey.GetPublicKeyRSAParameters(publicKeyPath);
            var key = new RsaSecurityKey(rsaParameters);
            key.KeyId = $"{kidPrefix}{key.KeyId}";
            //key.KeyId = "IDP";
            return key;
        }

        //kid and x5t auto populated
        //.cer
        public static X509SecurityKey LoadPrivateSigningCertificate(string privateSigningCertificatePath, string password, string kidPrefix = "")
        {
            X509Certificate2 privateCertificate = new X509Certificate2(privateSigningCertificatePath, password, X509KeyStorageFlags.PersistKeySet);
            var key = new X509SecurityKey(privateCertificate);
            key.KeyId = $"{kidPrefix}{key.KeyId}";

            return key;
        }

        //kid and x5t auto populated
        //.pfx
        public static X509SecurityKey LoadPublicSigningCertificate(string publicSigningCertificatePath, string kidPrefix = "")
        {
            var publicCertificate = new X509Certificate2(publicSigningCertificatePath);
            var key = new X509SecurityKey(publicCertificate);
            key.KeyId = $"{kidPrefix}{key.KeyId}";

            return key;
        }
    }
}
