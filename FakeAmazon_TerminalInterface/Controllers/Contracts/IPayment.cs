using FakeAmazon_TerminalInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeAmazon_TerminalInterface.Controllers.Contracts
{
    interface IPayment
    {
        void AddPaymentType(string name, int acctNum, int customerId);

        Customer GetCustomer(int customerId);

        List<Payment> GetPaymentList(int customerId);
    }
}
