using System;
using System.Text;

namespace DemoTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int power = 0;
            for (int i = 0; i < text.Length; i++)
            {
               char current = text[i];

                if(current == '>')
                {
                    power += int.Parse(text[i + 1].ToString());
                    sb.Append(current);
                }
                else if(power == 0)
                {
                    sb.Append(current);
                }
                else
                {
                    power--;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
