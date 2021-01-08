using System;

namespace _4.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var encryptedText = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                encryptedText += (char)(text[i] + 3);
            }
            Console.WriteLine(encryptedText);
        }
    }
}
