using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _7.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();
            

            int bomb = 0;
            for (int i = 0; i < text.Length; i++)
            {
                var symbol = text[i];
                
                
                if (symbol == '>')
                {
                    bomb += int.Parse(text[i + 1].ToString());
                    continue;
                }

                if(bomb > 0)
                {
                    text = text.Remove(i, 1);
                    i--;
                    bomb--;
                }

              
            }
            Console.WriteLine(text);
        }
    }
}
