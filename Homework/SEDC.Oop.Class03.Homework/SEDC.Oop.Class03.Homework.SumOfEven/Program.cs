using System;

namespace SEDC.Oop.Class03.Homework.SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 6 integers.");
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string c = Console.ReadLine();
                string d = Console.ReadLine();
                string e = Console.ReadLine();
                string f = Console.ReadLine();
                bool aValid = int.TryParse(a, out int first);
                bool bValid = int.TryParse(b, out int second);
                bool cValid = int.TryParse(c, out int third);
                bool dValid = int.TryParse(d, out int fourth);
                bool eValid = int.TryParse(e, out int fifth);
                bool fValid = int.TryParse(f, out int sixth);
                if(aValid && bValid && cValid && dValid && eValid && fValid)
                {
                    int[] numbers = new int[6] { first, second, third, fourth, fifth, sixth };
                    int result = 0;
                    foreach (int number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            result += number;
                        }
                    }
                    Console.WriteLine(result);
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid integers.");
                    continue;
                }
            }
            
        }
    }
}
