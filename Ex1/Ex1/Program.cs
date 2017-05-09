using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input \"r\"");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            double circumference = 2 * Math.PI * r;
            Console.WriteLine("The are of your circle is"+area);
            Console.WriteLine("The circumference of your circle is"+circumference);
            Console.ReadLine();

        }
    }
}
