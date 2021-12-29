using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The do while loop is the same as while loop except that it executes the code block at least once.
             * Codes will work between {} while condition is true.
             * Actually this is the hardes function to understand.
             * Because while condition is a little bit confused.
             * 
             */

            int num = 0;

            start:
            // Do executes the code block at least once.
            do
            {
                    Console.Write("Enter (1-15) number: ");
                    num = Convert.ToInt32(Console.ReadLine());

                 // Codes will continue to work while the condition is true.
                 // But don't forget.We want numbers (1–15), if someone 
                 // enter between so the condition has to be false because we don't want it to work again.
                 // If you look at the current condition, it is a little bit confusing. But don't worry if we enter 2
                 // 2 is < 1  ? [NO] |OR| 2 > 15 [NO] result is [NO] if result is no computer will skip loop.
                 // So we will see the console message, which is below. Congratulations 2 is between 1-15.
                } while (num <= 1 || num >= 15);


                Console.Write("Congratulations {0} is between 1-15"+"\n", num);
            goto start;


        }
    }
}
