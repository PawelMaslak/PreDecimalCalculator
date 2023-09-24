using Core.Abstraction;
using Core.Models;

namespace Core.Tests
{
    public class MonetaryUnitShould
    {
        [Fact]
        public void VerifyPoundSettings()
        {
            //Arrange
            string name = "Pound";
            string symbol = $"£";
            int unitsInHigherNominal = 0;

            //Act
            MonetaryUnit sut = new Pound(1);

            //Assert
            Assert.Equal(name, sut.Name);
            Assert.Equal(symbol, sut.Symbol);
            Assert.Equal(unitsInHigherNominal, sut.AmountInHigherNominal);
        }

        [Fact]
        public void VerifyShillingSettings()
        {
            //Arrange
            string name = "Shilling";
            string symbol = $"s";
            int unitsInHigherNominal = 20;

            //Act
            MonetaryUnit sut = new Shilling(1);

            //Assert
            Assert.Equal(name, sut.Name);
            Assert.Equal(symbol, sut.Symbol);
            Assert.Equal(unitsInHigherNominal, sut.AmountInHigherNominal);
        }

        [Fact]
        public void VerifyPennySettings()
        {
            //Arrange
            string name = "Penny";
            string symbol = $"p";
            int unitsInHigherNominal = 12;

            //Act
            MonetaryUnit sut = new Penny(1);

            //Assert
            Assert.Equal(name, sut.Name);
            Assert.Equal(symbol, sut.Symbol);
            Assert.Equal(unitsInHigherNominal, sut.AmountInHigherNominal);
        }
    }
}