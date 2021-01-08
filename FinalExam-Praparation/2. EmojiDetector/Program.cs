using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _2._EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberPattern = @"\d";
            string EmojiPattern =  @"(:{2}|\*{2})[A-Z][a-z]{2,}\1";
            Regex numReg = new Regex(numberPattern);
            Regex emojiReg = new Regex(EmojiPattern);


            string text = Console.ReadLine();
            long coolTreshold = 1;

            numReg.Matches(text).Select(m => m.Value).Select(int.Parse).ToList().ForEach(x => coolTreshold *= x);

            var matches = emojiReg.Matches(text);
            int totalEmojis = matches.Count;
            List<string> coolEmojis = new List<string>();

            foreach (Match item in matches)
            {
                long coolIndex = item.Value.Substring(2, item.Value.Length - 4).ToCharArray().Sum(x => (int)x);

                if(coolIndex > coolTreshold)
                {
                    coolEmojis.Add(item.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{totalEmojis} emojis found in the text. The cool ones are:");

            foreach (var item in coolEmojis)
            {
                Console.WriteLine(item);
            }

        }
    }
}
