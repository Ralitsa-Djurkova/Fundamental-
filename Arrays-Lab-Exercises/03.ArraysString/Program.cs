using System;

namespace _03.ArraysString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem, ipsum.Do re, la!Mi.";
            string[] separators = { ".", ",","!" };
            Console.WriteLine(text);
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length ; i++)
            {
                Console.WriteLine($"Array[{i}]={words[i]}");
            }
        }
    }
}
