using System;
using System.Linq;
using System.Threading;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int bestSequenceIndex = 0;
            int[] bestSequensArray = new int[n];

            //1 0 1 1 0
            int sequenceCounter = 0;


            while (command != "Clone them!")
            {
                int[] currentSequence = command
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCounter++; 

                int length = 1;
                int bestCurrentLength = 0;
                int startIndex = 0;
                int currentSecquenceSum = 0;

                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }

                    if (length > bestCurrentLength)
                    {
                        bestCurrentLength = length;
                        startIndex = i;
                    }
                    currentSecquenceSum += currentSequence[i];
                }

                currentSecquenceSum += currentSequence[n - 1];
                    if(bestCurrentLength > bestLength)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = startIndex;
                        bestSequenceSum = currentSecquenceSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequensArray = currentSequence.ToArray();
                    }
                    else if(bestCurrentLength == bestLength)
                    {
                        if(startIndex < bestStartIndex)
                        {
                            bestLength = bestCurrentLength;
                            bestStartIndex = startIndex;
                            bestSequenceSum = currentSecquenceSum;
                            bestSequenceIndex = sequenceCounter;
                            bestSequensArray = currentSequence.ToArray();
                        }
                        else if(startIndex == bestStartIndex)
                        {
                            if(currentSecquenceSum > bestSequenceSum)
                            {
                                bestLength = bestCurrentLength;
                                bestStartIndex = startIndex;
                                bestSequenceSum = currentSecquenceSum;
                                bestSequenceIndex = sequenceCounter;
                                bestSequensArray = currentSequence.ToArray();
                            }
                        }
                    }

                
                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(String.Join(' ',bestSequensArray));
        }
    }
}
