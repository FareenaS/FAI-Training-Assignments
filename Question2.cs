using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question2
    {
        static void Main(string[] args)
        {
            TakingUserInput();
        }

        public static void TakingUserInput()
        {
            //nt iter = 0;
            //Take the size of the array as input from the user
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());//Taking input from user for the size of the array
            int[] num = new int[size];

            //Take the input from the user for array elements
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                num[i] = int.Parse(Console.ReadLine());//Default input type is string so convert the string value to int value
            }
            EvenIntegers(num);
            OddIntegers(num);

        }

        private static void OddIntegers(int[] num)
        {
            Console.WriteLine("The odd numbers are: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)//Condition for odd integers
                {
                    Console.WriteLine(num[i] + " ");
                }

            }
        }

        private static void EvenIntegers(int[] num)
        {
            Console.WriteLine("The even numbers are: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)//Condition for even integers
                {
                    Console.WriteLine(num[i] + " ");
                }
                
            }
        }
    }
}
