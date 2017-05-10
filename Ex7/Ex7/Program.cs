using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool aTry=false;
            bool bTry=false;
            bool cTry=false;
            bool dTry=false;
            bool eTry=false;
            int sum = 0;
            while (aTry==false)
            {
                Console.WriteLine("Enter the first number");
                bool check = int.TryParse(Console.ReadLine(), out int a);
                aTry = check;
                sum += a;
            }
            while (bTry == false)
            {
                Console.WriteLine("Enter the second number");
                bool check = int.TryParse(Console.ReadLine(), out int b);
                bTry = check;
                sum += b;
            }
            while (cTry == false)
            {
                Console.WriteLine("Enter the third number");
                bool check = int.TryParse(Console.ReadLine(), out int c);
                cTry = check;
                sum += c;
            }
            while (dTry == false)
            {
                Console.WriteLine("Enter the forth number");
                bool check = int.TryParse(Console.ReadLine(), out int d);
                dTry = check;
                sum += d;
            }
            while (eTry == false)
            {
                Console.WriteLine("Enter the fifth number");
                bool check = int.TryParse(Console.ReadLine(), out int e);
                eTry = check;
                sum += e;
            }
            Console.WriteLine("The sum of the numbers is {0}",sum );
            Console.ReadLine();


        }
    }
}
