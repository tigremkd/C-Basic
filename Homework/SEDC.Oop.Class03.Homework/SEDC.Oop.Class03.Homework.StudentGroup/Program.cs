using System;

namespace SEDC.Oop.Class03.Homework.StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[] { "Igor", "Sara", "Atanas", "Ana", "Tanja" };

            Console.WriteLine("Choose from which group you want to get the names displayed : 1 or 2.");
            string usersChoice = Console.ReadLine();

            switch (usersChoice)
            {
                case "1":
                    Console.WriteLine("The students from group 1 are :");
                    foreach(string student in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                    case "2":
                    Console.WriteLine("The students from group 2 are : ");
                    foreach (string student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                default:
                    Console.WriteLine("Enter valid grp.");
                    break;
            }
        }
    }
}
