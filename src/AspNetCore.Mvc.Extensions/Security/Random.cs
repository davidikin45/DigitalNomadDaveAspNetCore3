using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AspNetCore.Mvc.Extensions.Security
{
    public static class Random
    {
        public static int GenerateRandomNumber(int length = 32)
        {
            using(var rng = new RNGCryptoServiceProvider())
            {
                var bytes = new byte[length];
                rng.GetBytes(bytes);

                return BitConverter.ToInt32(bytes, 0);
            }
        }
    }
}
