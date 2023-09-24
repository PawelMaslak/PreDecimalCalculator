using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Abstraction;

namespace Core.Models
{
    public class Pound : MonetaryUnit
    {
        public Pound(int amount) : base(amount)
        {
            Name = "Pound";
            Symbol = $"£";
        }
    }
}
