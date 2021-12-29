using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * İf condition is true.
             * {} code block to be executed.
             * 
             */
            int i = 1;
            while (i<10)
            {
                Console.WriteLine("Hey!");
                i = i + 1;
            }
            Console.ReadKey();
        }
    }
}
