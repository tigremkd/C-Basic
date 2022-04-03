using System;

namespace SEDC.Oop.Class04.Homework.AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateOfBirth = DateTime.Parse("04/04/1997");
            Console.WriteLine(AgeCalculator("10/10/1997"));





            Console.ReadLine();
        }


        static int AgeCalculator(string birthDate)
        {
            int result = 0;
            DateTime dateTime = DateTime.Now;
            DateTime parsedBirthDate = DateTime.Parse(birthDate);

            int birthdayYear = parsedBirthDate.Year;
            int birthdayMonth = parsedBirthDate.Month;
            int birthdayDay = parsedBirthDate.Day;
            int currentYear = dateTime.Year;
            int currentMonth = dateTime.Month;
            int currentDay = dateTime.Day;

            if (birthdayMonth <= currentMonth && birthdayDay <= currentDay)
            {
                result = currentYear - birthdayYear;
            }
            else
            {
                result = currentYear - (birthdayYear + 1);
            }

            return result;
        }


    }
}
