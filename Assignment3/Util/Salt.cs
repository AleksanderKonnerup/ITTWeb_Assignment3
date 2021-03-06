﻿using System.Security.Cryptography;

namespace Assignment3.Util
{
    public static class Salt
    {
        public static byte[] Create()
        {
            // generate a 128-bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }
    }
}
