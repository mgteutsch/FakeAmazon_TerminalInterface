using FakeAmazon_TerminalInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeAmazon_TerminalInterface
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool isRunning = true;

            Console.WriteLine("*********************************************************");
            Console.WriteLine("**  Welcome to Bangazon! Command Line Ordering System  **");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Choose active customer");
            Console.WriteLine("3. Create a payment option");
            Console.WriteLine("4. Add product to shopping cart");
            Console.WriteLine("5. Complete an order");
            Console.WriteLine("6. See product popularity");
            Console.WriteLine("7. Leave Bangazon!");

            Customer customer = new Customer();

            while (isRunning)
            {
                string userSelection = Console.ReadLine();

                if (userSelection == "1")
                {
                    Console.WriteLine("Great! Let's get you signed up!");
                    customer.CreateNewCustomer();
                }
                else if (userSelection == "7")
                {
                    Console.WriteLine("Thanks for visiting FakeAmazon! Have a nice day!");
                    isRunning = false;
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, that option is not valid. Please choose and option 1 through 7.");
                }
            }
        }
    }
}
