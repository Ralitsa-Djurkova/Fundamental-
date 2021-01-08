using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
             var text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            double result = 0;
            double sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string input = text[i];
                char letterBefor = input[0];
                char letterAfter =input[input.Length - 1];
                int number = int.Parse(input.Substring(1, input.Length - 2));

                int letterBeforNumber = char.Parse(letterBefor.ToString().ToUpper()) - 64;
                int letterAfterNumber = char.Parse(letterAfter.ToString().ToUpper()) - 64;

                if(letterBefor >= 65 && letterBefor <= 90)
                {
                    result = (double)(number / letterBeforNumber);
                    
                }
                else
                {
                    result =  (double)(number * letterBeforNumber);
                    
                }

                if(letterAfter >= 65 && letterAfter <= 90)
                {
                    result -= (double)letterAfterNumber; 
                    
                }
                else
                {
                    result += (double)letterAfterNumber;
                    
                }

                sum += result;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
