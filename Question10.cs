//Write a function called "inWords" that takes a number between 1 and 99,99,99,999 and returns a String representing the input number in words.

using System;

namespace Assignment1
{
    class Question10
    {


        static string[] one = { "", "one ", "two ", "three ", "four ",
                            "five ", "six ", "seven ", "eight ",
                            "nine ", "ten ", "eleven ", "twelve ",
                            "thirteen ", "fourteen ", "fifteen ",
                            "sixteen ", "seventeen ", "eighteen ",
                            "nineteen " };


        static string[] ten = { "", "", "twenty ", "thirty ", "forty ",
                            "fifty ", "sixty ", "seventy ", "eighty ",
                            "ninety " };

        // n is 1- or 2-digit number
        static string inWords(int n, string s)
        {
            string str = "";

            // if n is more than 19, divide it
            if (n > 19)
            {
                str += ten[n / 10] + one[n % 10];
            }
            else
            {
                str += one[n];
            }

            // if n is non-zero
            if (n != 0)
            {
                str += s;
            }

            return str;
        }

        // Function to print a given number in words
        static string convertToWords(int n)
        {

            // stores word representation of
            // given number n
            string out1 = "";

            // handles digits at hundred thousands
            // and one millions places (if any)
            out1 += inWords((int)((n / 100000) % 100),
                               "lakh ");

            // handles digits at thousands and tens
            // thousands places (if any)
            out1 += inWords((int)((n / 1000) % 100),
                               "thousand ");

            // handles digit at hundreds places (if any)
            out1 += inWords((int)((n / 100) % 10),
                               "hundred ");

            if (n > 100 && n % 100 > 0)
            {
                out1 += "and ";
            }

            // handles digits at ones and tens
            // places (if any)
            out1 += inWords((int)(n % 100), "");

            return out1;
        }

        // Driver code
        static void Main()
        {

            Console.WriteLine("------------Program to convert numbers to words-------------");
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            

            // convert given number in words
            if(n==0)
                Console.WriteLine("Enter number between 1 and 99,99,999");
            else
                Console.WriteLine(convertToWords(n));
        }
    }
}