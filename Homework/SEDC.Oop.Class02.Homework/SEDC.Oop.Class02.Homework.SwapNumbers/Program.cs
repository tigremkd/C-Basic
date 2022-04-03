using System;

namespace SEDC.Oop.Class02.Homework.SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Swap Numbers: Enter two(2) numbers !");
                string firstNum = Console.ReadLine();
                string secondNum = Console.ReadLine();
                bool isFirstValid = double.TryParse(firstNum, out double firstValid);
                bool isSecondValid = double.TryParse(secondNum, out double secondValid);
                if(isFirstValid && isSecondValid)
                {
                    Console.WriteLine($"Before swap:{firstValid}, {secondValid} ");
                    firstValid = firstValid + secondValid;
                    secondValid = firstValid - secondValid;
                    firstValid = firstValid - secondValid;
                    Console.WriteLine($"AFter swap : {firstValid}, {secondValid}");
                    break;
                }
                else
                {
                    Console.WriteLine("Press 1 if you wanna play again, press 2 to quit: ");
                    continue;
                    
                }
            }
        }
    }
}
