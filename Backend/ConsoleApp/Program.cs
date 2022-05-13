using ResumeBackend.Security;
using ResumeBackend.Models;
using ResumeBackend.DataAccess;
using ResumeBackend.Manager;
using ResumeBackend.Service;
using System.Security.Cryptography;

string testMessage = "this_is_a_test_message";
PasswordSalting hasher = new PasswordSalting();
SHA256 sha = SHA256.Create();

SaltyModel hashResultSha256 = hasher.PasswordCrypting(testMessage);
SaltyModel unhashFakeResult = hasher.PasswordDecrypting(testMessage, hashResultSha256.salt);

Console.WriteLine(hashResultSha256.salt);
Console.WriteLine(unhashFakeResult.salt); 
Console.WriteLine(hashResultSha256.message);
Console.WriteLine(unhashFakeResult.message);

