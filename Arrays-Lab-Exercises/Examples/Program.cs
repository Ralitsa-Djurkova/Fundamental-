using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            while(nums.Length > 1)
            {
                int[] arr = new int[nums.Length - 1];

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    arr[i] = nums[i] + nums[i + 1];
                }

                nums = arr;
            }
            Console.WriteLine($"{nums[0]}");
            

                  
                
            
        }
    }
}
