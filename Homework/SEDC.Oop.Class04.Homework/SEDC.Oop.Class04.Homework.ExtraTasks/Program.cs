using System;

namespace SEDC.Oop.Class04.Homework.ExtraTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Palindrome("madama"); Task 01

            //int[] numbers =
            //{
            //    1, 100, 300, 350, 4, 10, 220, 300
            //};

            //Console.WriteLine(GreatestNumber(numbers)); Task 02


            //Console.WriteLine("Number of digits : " + NumberOfDigits("100tigre3000"));
            //Console.WriteLine("Number of Vowels : " + NumberOfVowels("100tigre3000")); Task 03


            //UpperLower("TigreHelloASDF"); Task 04 ----- Ne znam kako da vratam string !


            Console.WriteLine(IsAlphabet('.')); // Task 05

            Console.WriteLine(NumberOfSubstrings("tigremantigremantigreman", "man")); //Task 6 (Pak ne e vo string ama se snajdov nekako hahaha)

            Console.WriteLine(PowerOf(5, 3)); // Task 07





            Console.ReadLine();


        }
        static void Palindrome(string str)
        {
            Console.WriteLine("The word you entered is : " + str);
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            string reversedString = new string(chars);
            Console.WriteLine("The word reversed is : " + reversedString);
            if (str == reversedString)
            {
                Console.WriteLine("Word is Palindrome");

            }
            else
            {
                Console.WriteLine("Word is not Palindrome");
            }
        }

        static int GreatestNumber(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            return max;
        }

        static int NumberOfDigits(string str)
        {
            int numberOfDigits = 0;
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsNumber(chars[i]))
                {
                    numberOfDigits++;
                }
            }
            return numberOfDigits;
        }

        static int NumberOfVowels(string str)
        {
            int numberOfVowels = 0;
            char[] chars = str.ToLower().ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a' || chars[i] == 'e' || chars[i] == 'i' || chars[i] == 'o' || chars[i] == 'u')
                {
                    numberOfVowels++;
                }
            }
            return numberOfVowels;
        }

        static void UpperLower(string str)
        {

            char[] chars = str.ToCharArray();
            //char[] newChars = new char [chars.Length];


            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsLower(chars[i]))
                {
                    //newChars[i] = (Char.ToUpper(chars[i]));
                    Console.WriteLine(Char.ToUpper(chars[i]).ToString());
                }
                else if (Char.IsUpper(chars[i]))
                {
                    //newChars[i] = (Char.ToLower(chars[i]));
                    Console.WriteLine(Char.ToLower(chars[i]).ToString());
                }
            }
            //return newChars.ToString();
        }

        static bool IsAlphabet(char character)
        {
            if (Char.IsLetter(character))
            {
                return true;
            }
            return false;
        }

        static int NumberOfSubstrings(string str, string subString)
        {
            int result = 0;
            //int strLength = str.Length;
            int subLength = subString.Length;

            str.ToCharArray();
            subString.ToCharArray();
            foreach (char c in str)
            {
                foreach (char c2 in subString)
                {
                    if (c == c2)
                    {
                        result++;
                    }
                }
            }
            return result / subLength;

        }

        static int PowerOf(int num1, int num2)
        {
            int result = 1;
            for (int i = 0; i < num2; i++)
            {
                result *= num1;
            }
            return result;
        }

    }
}
