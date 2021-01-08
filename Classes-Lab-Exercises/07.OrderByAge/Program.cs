using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<People> people = new List<People>();
            while (command != "End")
            {
                string[] elements = command.Split();
                string firstname = elements[0];
                string id = elements[1];
                int age = int.Parse(elements[2]);

                People people1 = new People(firstname, id, age);

                people.Add(people1);

                command = Console.ReadLine();
            }
            people = people.OrderBy(x => x.Age).ToList();

            foreach (People ages in people)
            {
                Console.WriteLine(ages);
            }
        }
    }

    class People
    {
        public People(string firstName, string id, int age)
        {
            Firstname = firstName;
            ID = id;
            Age = age;
        }
        public string Firstname { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Firstname} with ID: {ID} is {Age} years old.";
        }
    }
}
