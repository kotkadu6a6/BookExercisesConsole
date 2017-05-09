using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ssecond number");
            int b = int.Parse(Console.ReadLine());
            int counter=0;
            if (a<b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i%5==0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("The number of time your number occurs is "+counter);
            }
            else if (b<a)
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 5 == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("The number of time your number occurs is " + counter);
            }
            else
            {
                Console.WriteLine("Enter different numbers");
            }
            
            
            Console.ReadLine();


        }
    }
}
