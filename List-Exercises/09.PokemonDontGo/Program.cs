using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(long.Parse).ToList();
            long sum = 0;



            while (numbers.Count > 0) //4 5 3
            {
                int index = int.Parse(Console.ReadLine());
                long number;
                if (index < 0)
                {
                    number = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];

                }
                else if(index >= numbers.Count)
                {
                    number = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    number = numbers[index];
                    numbers.RemoveAt(index);
                }
                sum += number;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if(numbers[i] <= number)
                    {
                        numbers[i] += number;
                    }
                    else
                    {
                        numbers[i] -= number;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
