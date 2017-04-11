using FakeAmazon_TerminalInterface.DAL;
using FakeAmazon_TerminalInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeAmazon_TerminalInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
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

            Customer customer = new Models.Customer();
            */
            CustomerRepository customerRepo = new CustomerRepository();
            Console.WriteLine("Let's start with your name. Enter your first name below and press Enter:");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Hi there, " + userFirstName + "! Good to meet you. Now, enter your last name below and press Enter:");
            string userLastName = Console.ReadLine();

            Console.WriteLine("Great name. Let's get your address next. Type your street address first and press Enter:");
            string userStreet = Console.ReadLine();

            Console.WriteLine("Type the city you're located in and press Enter:");
            string userCity = Console.ReadLine();

            Console.WriteLine("Now enter the two-letter abbreviation of your state and press Enter:");
            string userState = Console.ReadLine();

            Console.WriteLine("And finally, enter your 5-digit zipcode and press Enter:");
            int userZipCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Awesome. Last item: just give use your 10-digit phone number (no hyphens, spaces, or parenthesis) and press Enter:");
            int userPhone = int.Parse(Console.ReadLine());


            customerRepo.AddNewCustomerNameStreetCityState(userFirstName, userLastName, userStreet, userCity, userState, userZipCode, userPhone);


            /*
            while (isRunning)
            {
                string userSelection = Console.ReadLine();

                if (userSelection == "1")
                {
                    Console.WriteLine("Great! Let's get you signed up!");
                    customerRepo.AddNewCustomerAccount(customerId, userFirstName, userLastName, userStreet, userCity, userState, userZipCode, userPhone);
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
        */
        }
    }
}
