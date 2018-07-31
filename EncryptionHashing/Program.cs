using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionHashing
{
    class Program
    {
        static void Main(string[] args)
        {
           //Don't know why they are not matched.
           //Might be that my byte array is only 15 bits and not 16 etc
            var storesPasswordHash = new byte[] {
                2,1,2,1,4,2,1,2,4,234,123,145,167,178,74
            };
            var password = Encoding.Unicode.GetBytes("JaNejOkej");
            Console.WriteLine(@"Bytes: {0}",password.First());
            var passwordHash = SHA256.Create().ComputeHash(password);
            Console.WriteLine(@"Hashed: {0}", passwordHash.FirstOrDefault());
            if (passwordHash.SequenceEqual(storesPasswordHash))
            {
                Console.WriteLine("Match.");
            }
            else
            {
                Console.WriteLine("Not matched.");
            }
            Console.Read();
        }
    }
}
