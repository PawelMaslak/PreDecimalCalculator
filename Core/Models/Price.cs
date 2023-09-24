using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Price
    {
        public Pound Pounds { get; set; }
        public Shilling Shillings { get; set; }
        public Penny Pennies { get; set; }

        //Master Constructor
        public Price(int pounds, int shillings, int pennies)
        {
            Pounds = new Pound(pounds);
            Shillings = new Shilling(shillings);
            Pennies = new Penny(pennies);
            VerifyPrice();
        }

        public Price() : this(0, 0, 0) { }
        public Price(int shillings, int pennies) : this(0, shillings, pennies) { }
        public Price(int pennies) : this(0, 0, pennies) { }

        public void VerifyPrice()
        {
            int extraShillingsFromPennies = Pennies.VerifyAmount();
            Shillings.Amount += extraShillingsFromPennies;

            int extraPoundsFromShillings = Shillings.VerifyAmount();
            Pounds.Amount += extraPoundsFromShillings;
        }

        public override string ToString()
        {
            return $"Test";
        }
    }
}
