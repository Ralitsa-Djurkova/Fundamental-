using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _06.LIstManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isChange = false;

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        isChange = true;
                        break;
                    case "Remove":
                        int numbersToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numbersToRemove);
                        isChange = true;
                        break;
                    case "RemoveAt":
                        int indexRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexRemove);
                        isChange = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        isChange = true;
                        break;
                    case "Contains":
                        string answer = string.Empty;
                        Console.WriteLine(numbers.Contains(int.Parse(tokens[1])) ? answer = "Yes" : answer = "No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ",numbers.Where(n => n %2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 1)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string result = string.Empty;
                        switch (tokens[1])
                        {
                            case "<":
                                result = string.Join(" ", numbers.Where(n => n < int.Parse(tokens[2])));
                                break;
                            case ">":
                                result = string.Join(" ", numbers.Where(n => n > int.Parse(tokens[2])));
                                break;
                            case "<=":
                                result = string.Join(" ", numbers.Where(n => n <= int.Parse(tokens[2])));
                                break;
                            case ">=":
                                result = string.Join(" ", numbers.Where(n => n >= int.Parse(tokens[2])));
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine(result);
                        break;
                }
            }

            
        }
    }
}
