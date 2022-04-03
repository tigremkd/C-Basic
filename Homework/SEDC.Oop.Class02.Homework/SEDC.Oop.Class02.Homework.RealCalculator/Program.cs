using System;

namespace SEDC.Oop.Class02.Homework.RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.WriteLine("Welcome to the Real Calculator ! Please enter your first number :");
                string firstNum = Console.ReadLine();
                bool isFirstValid = double.TryParse(firstNum, out double firstValid);
                Console.WriteLine("Enter your second number: ");
                string secondNum = Console.ReadLine();
                bool isSecondValid = double.TryParse(secondNum, out double secondValid);
                Console.WriteLine("Enter your mathematical operation:  ( +, - , * , / ).");
                string operation = Console.ReadLine();

                if (isFirstValid && isSecondValid)
                {
                    Console.WriteLine($"Your first num is {firstValid}, Your second number is {secondValid}, and your operation is : {operation}");
                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine("Your result is: " + (firstValid + secondValid));
                            break;
                        case "-":
                            Console.WriteLine("Your result is: " + (firstValid - secondValid));
                            break;
                        case "*":
                            Console.WriteLine("Your result is: " + (firstValid * secondValid));
                            break;
                        case "/":
                            Console.WriteLine("Your result is: " + (firstValid / secondValid));
                            break;
                            default:
                            Console.WriteLine($"Enter valid operation. {operation} is not valid. ");
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid numbers/operations");
                    continue;
                } 
            }
        }
    }
}
