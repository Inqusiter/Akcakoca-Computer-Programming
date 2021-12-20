using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, vat;
            Console.WriteLine("Vat calculator (%18)");

            step1:
            Console.Write("Please enter a value :");
            number1 = Convert.ToDouble(Console.ReadLine());

            vat = number1 / 100 * 18;

            Console.WriteLine("Entered value :{0} , Value with vat: {1} , Vat is :{2}", number1, number1+vat, vat);

            Console.WriteLine("\n"+"I am working again.."); // "\n" that command provides an empty line.
            goto step1;

        }
    }
}
