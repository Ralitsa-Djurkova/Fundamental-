using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split();
                string firstName = token[0];
                string lastName = token[1];
                double grade = double.Parse(token[2]);

                Students student = new Students(firstName, lastName, grade);

                students.Add(student);


            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Students currentSt in students)
            {
                Console.WriteLine(currentSt);
            }
        }
    }
    class Students
    {
        public Students(string firstname, string lastName, double grade)
        {
            FirstName = firstname;
            Lastname = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }

        public  string Lastname { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {Lastname}: {Grade:f2}";
        }
    }
}
