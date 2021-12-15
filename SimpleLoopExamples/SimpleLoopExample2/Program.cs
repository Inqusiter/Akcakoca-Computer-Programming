using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoopExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Hello, we are making simple examples with using for.
             * But here we will use something  we didn't learn at university.
             * That method is
             * 
             * anythingtype: 
             * 
             * goto anythingtype:
             * 
             * We are using that function to direct to step.
             * That function mission is starting our software again.
             * We don't want to open this again.
             * We have a chance to write Console.ReadKey(); but after the software will close suddenly. We need to open it again.
             */




            int Value1 = 0, Value2 = 0, Result, Loop;

            start:
            Console.Write("Hello, I am avarage calculator bot. How many times should ı work ? :");
            Loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Loop; i++)
            {
                Console.Write("Please enter first value : ");
                Value1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter second value : ");
                Value2 = Convert.ToInt32(Console.ReadLine());

                Result = (Value1 + Value2) / 2;
                Console.WriteLine("Avarege is :" + Result);
                Console.WriteLine("I am working again...");

            }

            goto start;

        }
    }
}
