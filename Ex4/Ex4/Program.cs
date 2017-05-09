using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a positive fraction number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a negative fraction");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0,-10:X}{1,-10:0.00}{2,-10:0.00}",a,b,c);
            Console.ReadLine();

        }
    }
}
