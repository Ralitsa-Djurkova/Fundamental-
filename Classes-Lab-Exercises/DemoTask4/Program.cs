using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DemoTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 0; i < countStudents; i++)
            {
                string[] studentName = Console.ReadLine().Split();
                string firstName = studentName[0];
                string lastName = studentName[1];
                double grade =double.Parse(studentName[2]);

                Students student = new Students(firstName, lastName, grade);

                students.Add(student);
            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Students curenStu in students)
            {
                Console.WriteLine(curenStu);
            }
        }
    }
    class Students
    {
        public Students(string firstname, string lastName, double grade)
        {
            Firstname = firstname;
            LastName = lastName;
            Grade = grade;
        }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{Firstname} {LastName}: {Grade:f2}";
        }
    }
}
