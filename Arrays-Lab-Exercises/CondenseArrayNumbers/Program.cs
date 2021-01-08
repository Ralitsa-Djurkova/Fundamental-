using System;
using System.Linq;

namespace CondenseArrayNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (nums.Length > 1)
            {
                int[] newArr = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    newArr[i] = nums[i] + nums[i + 1];

                }
                nums = newArr;
            }
            Console.WriteLine($"{nums[0]}");
        }
    }
}
