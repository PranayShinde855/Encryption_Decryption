using System;
using System.Security.Cryptography;
using System.Text;

namespace Encryption_Decryption_Using_RSA_Algorithm
{
    static class Program
    {
        public static string Encrypt(string plainText)
        {
            return plainText = Convert.ToBase64String(Encoding.Unicode.GetBytes(plainText));
        }

        public static string Decrypt(string cipherText)
        {
            return cipherText = Encoding.Unicode.GetString(Convert.FromBase64String(cipherText));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to encrypt");
            var plaintext = Console.ReadLine();
            
            var cipherText = Encrypt(plaintext);
            Console.WriteLine("Encrypted string :" + cipherText);

            var plainText2 = Decrypt(cipherText);
            Console.WriteLine("Decrypted string :" + plainText2);
        }
    }
}
