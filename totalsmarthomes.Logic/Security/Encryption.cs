using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace StoreFront.Service.Security
{
    public static class Encryption
    {
        public static string EncryptString(string value)
        {
            var salt = BitConverter.GetBytes(1412780073);

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)

            var returnValue = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: value,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return returnValue;
            
        }
    }
}
