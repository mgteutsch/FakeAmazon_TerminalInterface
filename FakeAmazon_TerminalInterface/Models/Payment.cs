using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeAmazon_TerminalInterface.Models
{
    class Payment
    {
        public string PaymentType { get; set; }

        public int PaymentTypeId { get; set; }

        public int AccountNumber { get; set; }
    }
}
