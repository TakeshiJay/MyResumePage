using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ResumeBackend.Models;

namespace ResumeBackend.Security
{
    public class PasswordSalting
    {
        public SaltyModel HashWithSalt(string password, int saltLen, HashAlgorithm algo)
        {
            RandomNumberGeneration rng = new RandomNumberGeneration();
            byte[] saltByte = rng.GenerateRandomCryptographicBytes(saltLen);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passWithSaltedBytes = new List<byte>();
            passWithSaltedBytes.AddRange(passwordAsBytes);
            passWithSaltedBytes.AddRange(saltByte);
            byte[] digestBytes = algo.ComputeHash(passWithSaltedBytes.ToArray());

            return new SaltyModel(Convert.ToBase64String(saltByte), Convert.ToBase64String(digestBytes));
        }
    }
}
