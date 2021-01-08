using System;

namespace _3.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split("\\");

            var lastElements = text[text.Length - 1];
            var arrya = lastElements.Split(".");

            var failName = arrya[0];
            var extention = arrya[1];

            Console.WriteLine(failName);
            Console.WriteLine(extention);

        }
    }
}
