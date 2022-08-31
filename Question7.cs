using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The function should check and return true only if the number passed as argument is a prime number.
//Write a C# program to call the above function multiple times with different values.

namespace Assignment1
{
    class Question7
    {
        static bool isPrimeNumber(int num)
        {
            for (int i = 2; i < num/2; i++)
                if (num % i == 0)
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            TakeUserInput();
        }

        private static void TakeUserInput()
        {
            Console.WriteLine("Function : To check a number is prime or not :");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Input a number : ");
            int n = int.Parse(Console.ReadLine());

            if (isPrimeNumber(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");
        }
    }
}
