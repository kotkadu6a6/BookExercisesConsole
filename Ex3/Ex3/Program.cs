using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the company name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter the company adress:");
            string companyAdress = Console.ReadLine();
            Console.WriteLine("Enter the company phone number:");
            int companyPhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the company fax number:");
            int companyFaxNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the company website:");
            string companyWebSite = Console.ReadLine();
            Console.WriteLine("Enter the manager first name:");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Enter the manager last name");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Enter the manager number");
            int managerNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The company "+companyName+" is located at "+companyAdress+
                ". It's phone number is "+companyPhoneNumber+" and their fax number is "+
                companyFaxNumber+". Their website is "+companyWebSite+
                "{0}{0}The manager of the company is called {1} {2} and his phone number is {3}",
                Environment.NewLine,managerFirstName,managerLastName,managerNumber);

            Console.ReadLine();

        }
    }
}
