using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace ResumeBackend.Security
{
    public class RandomNumberGeneration
    {
        /// <summary>
        /// Function generates a random cryptographic byte string and is determined by the key length
        /// </summary>
        /// <param name="keyLength"></param>
        /// <returns></returns>
        public string GenerateRandomCryptographicKey(int keyLength)
        {
            return Convert.ToBase64String(GenerateRandomCryptographicBytes(keyLength));
        }
        /// <summary>
        /// Generates a random byte string based on the length of the key that is sent to this function
        /// </summary>
        /// <param name="keyLength"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public byte[] GenerateRandomCryptographicBytes(int keyLength)
        {
            try
            {
                RandomNumberGenerator random = RandomNumberGenerator.Create();
                byte[] randomBytes = new byte[keyLength];
                random.GetBytes(randomBytes);
                return randomBytes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
