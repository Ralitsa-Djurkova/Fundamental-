using System;
using System.Collections.Generic;
using System.Text;

namespace StringAndTextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userName = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var validUserNames = new List<string>();
            for (int i = 0; i < userName.Length; i++)
            {
                string word = userName[i];
              
               
                if(word.Length >= 3 && word.Length <= 16)
                {
                    bool isValid = true;
                    for (int j = 0; j < word.Length; j++)
                    {
                        if(!(char.IsLetterOrDigit(word[j]) || word[j] == '-' || word[j] == '_'))
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        validUserNames.Add(word);
                    }

                   
                }
            }

            Console.WriteLine(string.Join("\n",validUserNames));
        }
    }
}
