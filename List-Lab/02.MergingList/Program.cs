using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _02.MergingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = ReadINtListSingleLine();
            var secondList = ReadINtListSingleLine();

            int count = Math.Max(firstList.Count, secondList.Count);
            Console.WriteLine(string.Join(" ",MergeLists(firstList, secondList)));

            
        }

        static List<int> ReadINtListSingleLine()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;

        }

        static List<int> MergeLists(List<int> first, List<int> second)
        {
            int count = Math.Max(first.Count, second.Count);
            List<int> merged = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if(first.Count > i)
                {
                    merged.Add(first[i]);
                }
                if(second.Count > i)
                {
                    merged.Add(second[i]);
                }
            }

            return merged;

        }
    }
}
