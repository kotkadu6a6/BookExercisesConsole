using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number ");
            int userNumber =int.Parse( Console.ReadLine());
            for (int i = 1; i <= userNumber; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
