using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTheRange();
        }

        private static void DisplayTheRange()
        {
            //Console.WriteLine($"The value of a number should be within {int.MinValue} and {int.MaxValue}");

            Console.WriteLine($"The range of int data type is {int.MinValue} and {int.MaxValue} ");
            Console.WriteLine($"The range of float data type is {float.MinValue} and {float.MaxValue} ");
            Console.WriteLine($"The range of double type is {double.MinValue} and {double.MaxValue} ");
            Console.WriteLine($"The range of short data type is {short.MinValue} and {short.MaxValue} ");
            Console.WriteLine($"The range of long data type is {long.MinValue} and {long.MaxValue} ");
            Console.WriteLine($"The range of unsigned int data type is {uint.MinValue} and {uint.MaxValue} ");
            Console.WriteLine($"The range of unsigned short data type is {ushort.MinValue} and {ushort.MaxValue} ");
            Console.WriteLine($"The range of unsigned long data type is {ulong.MinValue} and {ulong.MaxValue} ");
            Console.WriteLine($"The range of byte data type is {byte.MinValue} and {byte.MaxValue} ");
        }
    }
}
