using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                long lastNumber = 0;
                long newNumber = 1;
                long beforeLastNumber;
                if (n == 0)
                {
                }
                else if (n == 1)
                {
                    Console.WriteLine(lastNumber);
                }
                else if (n == 2)
                {
                    Console.WriteLine("{0}, {1}", lastNumber, newNumber);
                }
                else
                {
                    Console.Write("{0}, {1}, ", lastNumber, newNumber);

                    for (int i = 2; i < n; i++)
                    {
                        beforeLastNumber = lastNumber;
                        lastNumber = newNumber;
                        newNumber = beforeLastNumber + lastNumber;
                        if (i < n - 1)
                        {
                            Console.WriteLine("Number{0}{1}, ",i, newNumber);
                        }
                        else
                        {
                            Console.WriteLine(newNumber);
                        }


                    }
                }
                Console.ReadLine();
            }
        }
    }
}
