using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Abstraction;

namespace Core.Models
{
    public class Shilling : MonetaryUnit
    {
        public Shilling(int amount) : base(amount)
        {
            Name = "Shilling";
            Symbol = "s";
            AmountInHigherNominal = 20;
        }
    }
}
