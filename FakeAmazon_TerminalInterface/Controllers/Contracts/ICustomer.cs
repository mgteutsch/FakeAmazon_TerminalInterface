using FakeAmazon_TerminalInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeAmazon_TerminalInterface.Controllers.Contracts
{
    public interface ICustomer
    {
        void AddNewCustomerAccount(int customerId, string firstName, string lastName, string street, string city, int zipcode, int phone);

        /*
        Customer GetCustomerById(int customerId);
        List<Customer> GetListOfExisitingCustomers();
        */
    }
}
