using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Domain.ValueObjects
{
    public class Price
    {
        public decimal Valor { get; set; }
        public AcceptCurrency Currency { get; set; }
    }
}
