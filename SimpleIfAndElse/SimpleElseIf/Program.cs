using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This example for simlpe else if.
             * If functions are (if), (else if), (else)
             * If condition is false computer checks else if. If conditions are both of them false. Else will run.
             * Here is the wonderful example.
            ///////////////////////////////////////////////////////////////////

            if (condition1)
            {
                // block of code to be executed if condition1 is True
            }
            else if (condition2)
            {
                // block of code to be executed if the condition1 is false and condition2 is True
            }
            else
            {
                // block of code to be executed if the condition1 is false and condition2 is False
            }                           
             
            ///////////////////////////////////////////////////////////////////
             * The Computer first checks (if) if the result is true run (if) {}. 
             * If it's false, the program runs. (else if) {}.
             * Finally if both conditions are false, the computer runs (else) {}.
             * It is really hard to explain something without showing it.
             * Let's make a simple positive or negative else if example.
             * First run code with F5 after check lines. I am sure you will understand.
             * 
             */

            start:

            Console.Write("Please enter number:");
            step1:
            double num = Convert.ToDouble(Console.ReadLine());

            if (num>=0)
            {
                Console.Write("Number {0} positive!", num);
                Console.Write("\n" + "(I am if)"+ "\n");
            }

            else if (num<=-1)
            {
                Console.Write("Number {0} negative!", num);
                Console.Write("\n" + "I am else if" + "\n");
            }

            else
            {
                Console.Write("\n" + "Number {0} undefined" + "Please try again!",num);
                goto step1;
            }

            Console.WriteLine("\n" + "Starting again...");
            goto start;
        }
    }
}
