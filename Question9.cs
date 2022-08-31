using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question9
    {
        static void Main(string[] args)
        {
            TakeUserInput();
        }

        private static void TakeUserInput()
        {
            Console.WriteLine("--------------Program to Reverse a string by words-------------");
            Console.WriteLine("Enter a string to reverse:");
            string sentence = Console.ReadLine();
            reverseByWords(sentence);
        }

        public static void reverseByWords(string sentence)
        {
            Console.WriteLine(string.Join(" ", sentence.Split(' ').Reverse()));
        }
    }
}
