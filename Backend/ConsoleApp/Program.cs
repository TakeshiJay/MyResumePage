using ResumeBackend.Security;
using ResumeBackend.Models;
using ResumeBackend.DataAccess;
using ResumeBackend.Manager;
using ResumeBackend.Service;
using System.Security.Cryptography;

PasswordSalting hasher = new PasswordSalting();
SaltyModel hashResultSha256 = hasher.HashWithSalt("this_is_a_test_password", 64, SHA256.Create());
SaltyModel hashResultSha512 = hasher.HashWithSalt("this_is_a_test_password", 64, SHA512.Create());

Console.WriteLine(hashResultSha256.salt);
Console.WriteLine(hashResultSha256.message);
Console.WriteLine();
Console.WriteLine(hashResultSha512.salt);
Console.WriteLine(hashResultSha512.message);
