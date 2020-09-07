/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad VS = new VokunSalad();
            Assert.Equal(Size.Small, VS.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad VS = new VokunSalad();
            VS.Size = Size.Large;
            Assert.Equal(Size.Large, VS.Size);
            VS.Size = Size.Medium;
            Assert.Equal(Size.Medium, VS.Size);
            VS.Size = Size.Small;
            Assert.Equal(Size.Small, VS.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad VS = new VokunSalad();
            Assert.Empty(VS.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad VS = new VokunSalad();
            VS.Size = size;
            Assert.Equal(price, VS.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad VS = new VokunSalad();
            VS.Size = size;
            Assert.Equal(calories, VS.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad VS = new VokunSalad();
            VS.Size = size;
            Assert.Equal(name, VS.ToString());
        }
    }
}