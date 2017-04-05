using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeAmazon_TerminalInterface.AccountOptions
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public int Phone { get; set; }

        public void CreateNewCustomer()
        {
            Customer customer = new Customer();


            Console.WriteLine("Let's start with your name. Enter your first name below and press Enter:");
            customer.FirstName = Console.ReadLine();

            Console.WriteLine("Hi there, " + customer.FirstName + "! Good to meet you. Now, enter your last name below and press Enter:");
            customer.LastName = Console.ReadLine();

            Console.WriteLine("Great name. Let's get your address next. Type your street address first and press Enter:");
            customer.Street = Console.ReadLine();

            Console.WriteLine("Type the city you're located in and press Enter:");
            customer.City = Console.ReadLine();

            Console.WriteLine("Now enter the two-letter abbreviation of your state and press Enter:");
            customer.State = Console.ReadLine();

            Console.WriteLine("And finally, enter your 5-digit zipcode and press Enter:");
            customer.Zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Awesome. Last item: just give use your 10-digit phone number (no hyphens, spaces, or parenthesis) and press Enter:");
            customer.Phone = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Thank you - your Customer Profile has been set up!");
        }
    }
}
