using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction
{
    public abstract class MonetaryUnit
    {
        public string Name { get; set; } = string.Empty;
        public int AmountInHigherNominal { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public int Amount { get; set; } //Change to uShort!

        protected MonetaryUnit(int amount)
        {
            Amount = amount;
        }

        public int VerifyAmount()
        {
            if (Amount < AmountInHigherNominal) return 0;

            int higherAmountUnits = Amount / AmountInHigherNominal;
            Amount -= (higherAmountUnits * AmountInHigherNominal);
            return higherAmountUnits;
        }
    }
}
