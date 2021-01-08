using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Hp = new Dictionary<string, int>();
            Dictionary<string, int> Mp = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            int maxHp = 100;
            int maxMp = 200;


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int inputHp = int.Parse(input[1]);
                int inputMp = int.Parse(input[2]);

                Hp[name] = inputHp > maxHp ? maxHp : inputHp;//взимаме inputHp проверяваме дали е по голям от maxHp, ако е вярно ... анд хе е сепване го inputHP
                Mp[name] = inputMp > maxMp ? maxMp : inputMp;
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] token = command.Split(" - ");
                string instruction = token[0];

                if (instruction == "CastSpell")
                {
                    string heroName = token[1];
                    int Mpneeded = int.Parse(token[2]);
                    string spellName = token[3];

                    if (Mp[heroName] >= Mpneeded)
                    {
                        Mp[heroName] -= Mpneeded;

                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {Mp[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (instruction == "TakeDamage")
                {
                    string heroName = token[1];
                    int damage = int.Parse(token[2]);
                    string attacker = token[3];

                    Hp[heroName] -= damage;

                    if (Hp[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {Hp[heroName]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        Hp.Remove(heroName);
                        Mp.Remove(heroName);
                    }
                }
                else if (instruction == "Recharge")
                {
                    string heroName = token[1];
                    int amount = int.Parse(token[2]);
                    int mpBefor = Mp[heroName];
                    Mp[heroName] += amount;

                    if (Mp[heroName] > maxMp)
                    {
                        Mp[heroName] = maxMp;

                    }
                    int mpAfter = Mp[heroName];
                    int totalAmount = mpAfter - mpBefor;
                    Console.WriteLine($"{heroName} recharged for {totalAmount} MP!");
                }
                else if (instruction == "Heal")
                {
                    string heroName = token[1];
                    int amount = int.Parse(token[2]);
                    int hpBefor = Hp[heroName];
                    Hp[heroName] += amount;
                    if (Hp[heroName] > maxHp)
                    {
                        Hp[heroName] = maxHp;

                    }
                    int hpAfter = Hp[heroName];
                    int totalAmount = hpAfter - hpBefor;
                    Console.WriteLine($"{heroName} healed for {totalAmount} HP!");

                }
                command = Console.ReadLine();
            }


            foreach (var hero in Hp.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"HP: {hero.Value}");
                Console.WriteLine($"MP: {Mp[hero.Key]}");
            }
        }
    }
}
