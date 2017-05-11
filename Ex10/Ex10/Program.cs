using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the amount of numbers");
            int input = int.Parse(Console.ReadLine());
            uint number = new int();
            long sum = new int();
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine("Input a number to sum:");
                number = uint.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The sum of the numbers is: "+sum);
            Console.ReadLine();
        }
    }
}
