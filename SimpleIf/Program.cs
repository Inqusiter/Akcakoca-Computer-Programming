using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIf
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Hello, this example for simple if. We will see if function. As u know if is condition. There are two result in if.
             * Computer checks whether the condition is met. Computer uses bool; true or false.
             * The result has to be  true or false. If function checks the result, if the result is true {} between codes will run.
             * If condition is false. Computer will skip the {} lines.
             * Let's make a simple example.
             * Also, you will see different definitions. You can understand them.
             * == This is an operator. I will drop 2 resources here. One is for my Turk friends:)
             * Turkish Guide https://bidb.itu.edu.tr/seyir-defteri/blog/2013/09/06/c-'-ta-kullan%C4%B1lan-operat%C3%B6rler-ve-i%C5%9Flevleri
             * English Guide https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
             *
             */

            start:

            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            if (num%2==0)
            {
                Console.WriteLine("\n"+"{0} is a even!",num);
            }

            Console.WriteLine("\n"+"Please enter again...");
            goto start;
        }
    }
}
