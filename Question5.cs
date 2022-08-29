using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Function that returns a interest amount for a Principal Amount for a term with a specific rate of interest Let the inputs for the function be in the form of parameters.

namespace Assignment1
{
    class Question5
    {
        static void Main(string[] args)
        {
            TakeUserInput();
        }

        private static void TakeUserInput()
        {
            //float P = 10, R = 150, T = 2;

            //// Calculate simple interest
            //float SI = (P * T * R) / 100;
            //Console.Write("Simple interest = " + SI\n)

            Console.WriteLine("Enter the Principal amount:");
            float principal = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Time Period:");
            int time = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Rate of Interest:");
            float rate = float.Parse(Console.ReadLine());

            SICalculation(principal,time,rate);
        }

        private static void SICalculation(float p, int t, float r)
        {
            double SimpleIntrest = (p * t * r) / 100;
            Console.WriteLine($"The calculated simple intrest for the principal amount Rs.{p} for a time period of {t} years at the rate of intrest {r}% is Rs.{SimpleIntrest} ");
        }
    }
}
