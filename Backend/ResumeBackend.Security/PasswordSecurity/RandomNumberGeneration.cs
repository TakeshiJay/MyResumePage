using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ResumeBackend.Security
{
    public class RandomNumberGeneration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyLength"></param>
        /// <returns></returns>
        public string GenerateRandomCryptographicKey(int keyLength)
        {
            return Convert.ToBase64String(GenerateRandomCryptographicBytes(keyLength));
        }
        /// <summary>
        /// 
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
