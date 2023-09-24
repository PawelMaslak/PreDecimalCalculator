using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Abstraction;

namespace Core.Models
{
    public class Penny : MonetaryUnit
    {
        public Penny(int amount) : base(amount)
        {
            Name = "Penny";
            AmountInHigherNominal = 12;
            Symbol = "p";
        }
    }
}
