using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoopExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, Result = 0;
            Console.WriteLine("Hello, I am Addition bot. I am programmed  to collect 10 values entered externally.");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("First number:");
                Num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Second number:");
                Num2 = Convert.ToInt32(Console.ReadLine());

                Result = Num1 + Num2 + Result;
            }
            Console.WriteLine("Collection is :" + Result);
            Console.ReadKey();
        }
    }
}
