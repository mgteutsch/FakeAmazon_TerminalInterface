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
            Console.WriteLine("Let's start with your name. Enter your first name below and press Enter:");
            string FirstName = Console.ReadLine();

        }
    }
}
