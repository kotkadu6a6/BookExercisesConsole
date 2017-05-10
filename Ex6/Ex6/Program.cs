using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            int b = int.Parse(Console.ReadLine());
            int max = Math.Max(a, b);
            Console.WriteLine(max);
            Console.ReadLine();

        }
    }
}
