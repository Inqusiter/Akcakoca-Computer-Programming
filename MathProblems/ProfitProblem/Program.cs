using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double price, percentage, profit;

            Console.WriteLine("Profit calculator with %"+"\n");

            step1:

            Console.Write("Enter the price :");
            price = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n"+"Enter the profit (Don't put %) percentage :");
            percentage = Convert.ToDouble(Console.ReadLine());

            profit = price / 100 * percentage;

            Console.WriteLine("\nEntered price :{0} \nRaise amount is :{1} \nDesired profit % is :{2}  \nYou have to put price :{3} " + "\n", price, profit, percentage, profit+price);
            Console.WriteLine("Starting again.. \n");

            goto step1;

        }
    }
}
