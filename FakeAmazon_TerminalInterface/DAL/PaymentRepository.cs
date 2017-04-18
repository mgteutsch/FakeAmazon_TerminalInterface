using FakeAmazon_TerminalInterface.Controllers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeAmazon_TerminalInterface.Models;

namespace FakeAmazon_TerminalInterface.DAL
{
    class PaymentRepository : IPayment
    {
        public void AddPaymentType(string name, int acctNum, int customerId)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetPaymentList(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
