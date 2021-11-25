using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimlpeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
             *  Attention! Green colored sentences in your screen they are comment lines computer won't read them. 
             *  We  define values ​​that can be assigned to the computer as int because int is number value. 
             *  We have a chance assign them before converting but this is will be complicated for us we need the clear codes. 
             *  Examples
             *  Console.WriteLine("Please Enter First Number");
             *  int number1;
             *  number1 = Convert.ToInt32(Console.ReadLine());
             *  Console.WriteLine("Please Enter Second Number");
             *  int number2;
             *  number2 = Convert.ToInt32(Console.ReadLine());
            */

            // This is the clear one.
            int number1, number2, result;

            //This line is for the first message.
            Console.WriteLine("Simple Math");

            //The first line contains the message. The second line converts string to int, then we assign the entered value (it has to be a number or it will crash) to number1. 
            Console.WriteLine("Please Enter First Number");
            number1 = Convert.ToInt32(Console.ReadLine());

            //The first line contains the message. The second line converts string to int, then we assign the entered value (it has to be a number or it will crash) to number2.
            Console.WriteLine("Please Enter Second Number");
            number2 = Convert.ToInt32(Console.ReadLine());

            /* These lines are about math problems.
            * If we want to solve other math problems, we need to change the symbol. Here are a few symbols. You can search for them on Google.
            * Don't forget these symbols are different on computer. We are not using what we learn in class like [2X2=4] They can also be different in other languages.
            * [+,-,*,/]
            * [Addiction] +
            * [Subtraction] -
            * [Multiplication] *
            * [Division] /
            */
            // This line solves a math problem. Computer will calculate  what we entered.
            result = number1 + number2;
            Console.WriteLine("Result " + result);

            //This line dont have any function for now. This line waiting key from the user so it is letting our result staying on screen.
            //If we delete this line console will close suddenly. Because computer is so fast. It will solve problem then  shutdown  by itself.
            Console.ReadKey();
        }
    }
}
