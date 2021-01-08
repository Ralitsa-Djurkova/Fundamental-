using System;
using System.Data;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            int initionalEnergy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int win = 0;

            while (command != "End of battle")
            {

                int distance = int.Parse(command);


                if (initionalEnergy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {win} won battles and {initionalEnergy} energy");
                    return;
                }
                initionalEnergy -= distance;
                win++;
                if (win % 3 == 0)
                {
                    initionalEnergy += win;
                }

                command = Console.ReadLine();

            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {win}. Energy left: {initionalEnergy}");
                
            }

        }
    }
}
