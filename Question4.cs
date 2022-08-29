using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a function that takes an array of integers as arg and it should display the sum of odd Numbers and the sum of Even numbers from the array. Call the function in the Main program and call it multiple times to see the valid outputs

namespace Assignment1
{
    class Question4
    {
        static void Main(string[] args)
        {
            TakingUserInput();
        }

        public static void TakingUserInput()
        {
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());//Taking input from user for the size of the array
            int[] num = new int[size];

            //Take the input from the user for array elements
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                num[i] = int.Parse(Console.ReadLine());//Default input type is string so convert the string value to int value
            }
            sumOfEvenIntegers(num);
            sumOfOddIntegers(num);
        }

        private static void sumOfOddIntegers(int[] num)
        {
            int odd = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)//Condition for odd integers
                {
                    odd += num[i];
                }

            }
            Console.WriteLine($"The sum of odd numbers of array is {odd}");
        }

        private static void sumOfEvenIntegers(int[] num)
        {
            int even = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)//Condition for odd integers
                {
                    even += num[i];
                }

            }
            Console.WriteLine($"The sum of even numbers of array is {even}");
        }
    }
}
