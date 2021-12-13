using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimlpeForLoop
{
    class Program
    {
        static void Main(string[] args)
        // First and foremost, This is the second step in our process.If you have no idea what is going on here, you should study SimpleMath.
        // Here you go https://github.com/Inqusiter/Akcakoca-Computer-Programming/blob/main/SimpleMath/Program.cs#L14
        // If you don't want to write a line with a keyboard, you can use a shortcut. You need to type [for](Press Tab), then press TAB twice.
        // Let's make a simple Addition 1 to 10 numbers.
        {

            int Addition;
            Addition = 0;
            // Expression that will work as long as the current value
            for (int i = 0; i <= 10; i++)
                // This means that i is a  number(int)
                // i <= length || If i <= length continue work. If it is not stop.
                // i+(Value to increase) || i++ ---> i = i+1
            {
                Addition = Addition + i;
            }
            Console.WriteLine("Result ;" + Addition);
            Console.ReadKey();
        }
    }
}
