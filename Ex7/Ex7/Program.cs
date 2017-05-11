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
            {               
                int [] number = new int[5];
                for (int a = 0; a < 5; a++)
                {
                    Console.WriteLine("Enter a number:");
                    number[a] = int.Parse(Console.ReadLine());
                }
                if (number[0]>number[1]&&number[0]>number[2]&&
                    number[0]>number[3]&&number[0]>number[4])
                {
                    Console.WriteLine("The bigest number is: "+number[0]);
                }
                else if (number[1] > number[2] && number[1] > number[3] &&
                    number[1] > number[4])
                {
                    Console.WriteLine("The biggest number is: ",number[1]);
                }
                else if (number[2] > number[3] && number[2] > number[4])
                {
                    Console.WriteLine("The biggest number is: ",number[2]);
                }
                else if (number[3] > number[4])
                {
                    Console.WriteLine("The biggest is: ",number[3]);
                }
                else
                {
                    Console.WriteLine("The bigest number is ",number[4]);
                }
                Console.ReadLine();
            }
        }
    }
}
