using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The function should check if the parameter values constitute a valid calendar date or not. Accordingly return true or false.
//For example,
//year = 2018, month = 13, day = 1 is an invalid date as the possible values for month is 1 to 12.
//year=2018, month = 2, day = 29 is an invalid date as the maximum days in February is 28 in the year 2018
//year=2016, month = 2, day = 29 is a valid date.
//Write a C# program to call the above function multiple times with different values.

namespace Assignment1
{
    class Question6
    {
        //Setting maximum and minimum value for year
        const int MAX_VALID_YR = 9999;
        const int MIN_VALID_YR = 1800;

        //Check if the year is leap or not
        static bool isLeap(int year)
        {
            //Condition for leap year
            return (((year % 4 == 0) &&(year % 100 != 0)) ||(year % 400 == 0));
        }
        static bool isValidDate(int d, int m, int y)
        {
            // If year, month and day are not in given range
            if (y > MAX_VALID_YR || y < MIN_VALID_YR)
                return false;
            if (m < 1 || m > 12)
                return false;
            if (d < 1 || d > 31)
                return false;

            // Handle February month with leap year
            if (m == 2)
            {
                if (isLeap(y))
                    return (d <= 29);
                else
                    return (d <= 28);
            }

            // Months of April, June,Sept and Nov must have number of days less than or equal to 30.
            if (m == 4 || m == 6 || m == 9 || m == 11)
                return (d <= 30);

            return true;
        }

        static void Main(string[] args)
        {
            TakeUserInput();
        }

        private static void TakeUserInput()
        {
            Console.WriteLine("------------Program to check if the entered date is valid or invalid");

            Console.WriteLine("Enter the date:");
            int date = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the month:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the year:");
            int year = int.Parse(Console.ReadLine());

            if (isValidDate(date, month, year)) 
                Console.WriteLine("You have entered a valid date.");
            else
                Console.WriteLine("You have entered a invalid date");
        }
    }
}
