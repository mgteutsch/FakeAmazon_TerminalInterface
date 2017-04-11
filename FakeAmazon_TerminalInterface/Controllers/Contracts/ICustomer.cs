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
        void AddNewCustomerNameStreetCityState(string userFirstName, string userLastName, string userStreet, string userCity, string userState, int userZipCode, int userPhone);
        //void AddNewCustomerZipCodeAndPhoneNumber(int userZipCode, int userPhone);
        /*
        void Customer GetCustomerById(int customerId);
        void List<Customer> GetListOfExisitingCustomers();
        */


    }
}
