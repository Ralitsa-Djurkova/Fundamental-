using System;
using System.Linq;
using System.Text;

namespace FinalExam10._04.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretMessege = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] token = input.Split(":|:",StringSplitOptions.RemoveEmptyEntries);
                string instruction = token[0];

                if(instruction == "InsertSpace")
                {
                    int index = int.Parse(token[1]);
                    secretMessege =  secretMessege.Insert(index, " ");
                    
                }
                else if(instruction == "Reverse")
                {
                    string substring = token[1];
                    

                    if (secretMessege.Contains(substring))
                    {
                        secretMessege =  secretMessege.Remove(secretMessege.IndexOf(substring, substring.Length));
                        var reversed = new string(substring.Reverse().ToArray());
                        secretMessege += reversed;
                        
                    }
                    else
                    {
                        Console.WriteLine("error");
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if(instruction == "ChangeAll")
                {
                    string substring = token[1];
                    string replacement = token[2];

                    secretMessege =  secretMessege.Replace(substring, replacement);
                    
                }

                Console.WriteLine(secretMessege);
                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {secretMessege}");
        }
    }
}
