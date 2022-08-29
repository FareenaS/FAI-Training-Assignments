using System;

namespace Assignment
{
    class Util
    {
        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int GetNumber(string question)
        {
            return int.Parse(GetString(question));
        }
        public static short GetShortNumber(string question) => short.Parse(GetString(question));

        public static double GetDoubleNumber(string question) => double.Parse(GetString(question));
    }
    class Question3
    {
        const string menu = "----------Calculator Program-----------\nTo Add ----->Press 1\nTo Subtract ----->Press 2\nTo Multiply -------->Press 3\nTo Divide --------->Press 4\n";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int val2 = int.Parse(Console.ReadLine());
            bool processing = true;
            do
            {
                int choice = Util.GetNumber(menu);
                processing = processMenu(choice,val1,val2);
            } while (processing);
        }



        private static bool processMenu(int choice,int val1,int val2)
        {
            if (choice == 1)
            {
                int add = val1 + val2;
                Console.WriteLine($"The addition of {val1} and {val2} is {add}");
            }
            else if (choice == 2)
            {
                int sub = val1 - val2;
                Console.WriteLine($"The addition of {val1} and {val2} is {sub}");
            }
            else if (choice == 3)
            {
                int mul = val1 * val2;
                Console.WriteLine($"The addition of {val1} and {val2} is {mul}");
            }
            else if (choice == 4)
            {
                int div = val1 / val2;
                Console.WriteLine($"The addition of {val1} and {val2} is {div}");
            }
            else
                return false;
            return true;
        }
    }
}