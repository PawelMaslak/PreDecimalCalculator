using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Tests
{
    public class PriceShould
    {
        [Fact]
        public void SetCorrectAmountOfPennies()
        {
            //Arrange
            int expectedAmountOfPennies = 10;

            //Act
            Price sut = new Price(10);

            //Assert
            Assert.Equal(expectedAmountOfPennies, sut.Pennies.Amount);
        }

        [Fact]
        public void SetCorrectAmountOfShillingsAndPennies()
        {
            //Arrange
            int expectedAmountOfShillings = 1;
            int expectedAmountOfPennies = 10;

            //Act
            Price sut = new Price(1, 10);

            //Assert
            Assert.Equal(expectedAmountOfShillings, sut.Shillings.Amount);
            Assert.Equal(expectedAmountOfPennies, sut.Pennies.Amount);
        }

        [Fact]
        public void SetCorrectPrice()
        {
            //Arrange
            int expectedAmountOfPounds = 1;
            int expectedAmountOfShillings = 1;
            int expectedAmountOfPennies = 10;

            //Act
            Price sut = new Price(1, 1, 10);

            //Assert
            Assert.Equal(expectedAmountOfPounds, sut.Pounds.Amount);
            Assert.Equal(expectedAmountOfShillings, sut.Shillings.Amount);
            Assert.Equal(expectedAmountOfPennies, sut.Pennies.Amount);
        }

        [Fact]
        public void VerifyPrice()
        {
            //Arrange & Act
            Price incorrectPrice = GetIncorrectlyWrittenPrice();
 
            //Assert
            Assert.Equal(2, incorrectPrice.Pounds.Amount);
            Assert.Equal(8, incorrectPrice.Shillings.Amount);
            Assert.Equal(0, incorrectPrice.Pennies.Amount);
        }

        private Price GetIncorrectlyWrittenPrice()
        {
            return new Price(1, 25, 36);
        }

        private Price GetCorrectPrice()
        {
            return new Price(2, 8, 0);
        }
    }
}
