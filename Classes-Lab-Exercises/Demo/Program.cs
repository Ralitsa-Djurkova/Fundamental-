using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split(" ");
                string cmdArg = input[0];


                if (cmdArg == "swap")
                {
                    int index1 = int.Parse(input[1]);
                    int index2 = int.Parse(input[2]);

                    int number1 = array[index1];
                    int numbers2 = array[index2];
                    array.RemoveAt(index1);
                    array.Insert(index1, numbers2);
                    if (index2 > array.Count - 1)
                    {
                        index2 = array.Count - 1;
                        array.RemoveAt(index2);
                        array.Insert(index2, number1);
                    }
                    else
                    {
                        array.RemoveAt(index2);
                        array.Insert(index2, number1);

                    }
                }
                if (cmdArg == "multiply")
                {
                    int index1 = int.Parse(input[1]);
                    int index2 = int.Parse(input[2]);
                    int number1 = array[index1];
                    int number2 = array[index2];
                    int multiply = number1 * number2;
                    array.RemoveAt(index1);
                    array.Insert(index1, multiply);

                }
                if (cmdArg == "decrease")
                {
                    for (int i = 0; i < array.Count; i++)
                    {
                        array[i] -= 1;
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
