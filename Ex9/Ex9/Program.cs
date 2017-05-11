using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {            char loop = 'y';

            while (loop=='y')
            {
                Console.Clear();
                Console.WriteLine("Input the value of \"a\"");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Input the value of \"b\"");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Input the value of \"c\"");
                int c = int.Parse(Console.ReadLine());
                double d = new double();
                double x = new double();
                double x1 = new double();
                double x2 = new double();
                double x3 = new double();
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("Every \"x\" is a solution");
                        }
                        else
                        {
                            Console.WriteLine("There is no solution");
                        }
                    }
                    else
                    {
                        x = -(c / b);
                        Console.WriteLine(x);
                    }
                }
                else
                {
                    d = (b*b) - 4 * a * c;
                    if (d > 0)
                    {
                        x1 = ((-b) - Math.Sqrt(d)) / 2 * a;
                        x2 = ((-b) + Math.Sqrt(d)) / 2 * a;
                        Console.WriteLine("The solutions are:\n {0:00.000} \n and \n {1:00.000}", x1, x2);
                    }
                    else if (d < 0)
                    {
                        Console.WriteLine("There si no solution");
                    }
                    else if (d == 0)
                    {
                        x3 = (-b) / (2 * a);
                        Console.WriteLine("The solution is: " + x3);

                    }
                }
                Console.WriteLine("Solve another one? (y/n)");
                loop = Convert.ToChar(Console.ReadLine());
            }
            Environment.Exit(0);
            

        }
    }
}
