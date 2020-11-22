using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AspNetCore.Mvc.Extensions.Security
{
    class RSANewDigitalSignature
    {
        private RSA rsa;

        public RSANewDigitalSignature()
        {
            rsa = RSA.Create(2048);
        }

        public static byte[] ComputeHashSha256(byte[] toBeHashed)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(toBeHashed);
            }
        }

        public (byte[] Signature, byte[] Hash) SignData(byte[] dataToSign)
        {
            byte[] hashOfDataToSign = ComputeHashSha256(dataToSign);

            return (rsa.SignHash(hashOfDataToSign, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1), hashOfDataToSign);
        }

        public bool VerifySignature(byte[] signature, byte[] hashOfDataToSign)
        {
            return rsa.VerifyHash(hashOfDataToSign, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
        }

        //https://vcsjones.dev/2019/10/07/key-formats-dotnet-3/
        //https://www.scottbrady91.com/C-Sharp/PEM-Loading-in-dotnet-core-and-dotnet
        //https://blog.ndpar.com/2017/04/17/p1-p8/
        public byte[] ExportEncryptedPkcs8PrivateKey(string password, int numberOfIterations = 100000)
        {
            byte[] encryptedPrivateKey;

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
}
