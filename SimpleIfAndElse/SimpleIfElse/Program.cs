using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This example for simple if and else. We will see else function.
             * Computer checks whether the condition is met. If condition is not met.
             * Computer will check else.
             * Let's make a simple example.
             * 
             */

            start:

            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            if (num % 2 == 0)
            {
                Console.WriteLine("\n" + "{0} is a even number!", num);
            }
            else
            {
                Console.WriteLine("\n"+ "{0} is a odd number!", num);
            }

            Console.WriteLine("\n" + "Please enter again...");
            goto start;




        }
    }
}
