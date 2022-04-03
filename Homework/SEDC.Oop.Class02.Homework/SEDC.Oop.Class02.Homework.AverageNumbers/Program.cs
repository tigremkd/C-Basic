using System;

namespace SEDC.Oop.Class02.Homework.AverageNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //int numberOfInputs = 4;
                //double result = 0;
                //for (int i = 0; i < numberOfInputs; i++)
                //{
                //    string input = Console.ReadLine();

                //    bool isValidInput = double.TryParse(input, out double validInput);
                //    if (isValidInput)
                //    {
                //        result += validInput;

                //    }

                //double convertedResult = result / numberOfInputs;
                Console.WriteLine("Welcome to Average Number: Enter four(4) numbers.");
                string firstNum = Console.ReadLine();
                string secondNum = Console.ReadLine();
                string thirdNum = Console.ReadLine();
                string fourthNum = Console.ReadLine();
                bool isFirstValid = double.TryParse(firstNum, out double firstValid);
                bool isSecondValid = double.TryParse(secondNum, out double secondValid);
                bool isThirdValid = double.TryParse(thirdNum, out double thirdValid);
                bool isFourthValid = double.TryParse(fourthNum, out double fourthValid);

                if (isFirstValid && isSecondValid && isThirdValid && isFourthValid)
                {
                    double result = (firstValid + secondValid + thirdValid + fourthValid) / 4;
                    Console.WriteLine($"The average of {firstValid}, {secondValid}, {thirdValid}, {fourthValid} is : {result}");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid numbers");
                    continue;
                }

            }
        }
    }
}
