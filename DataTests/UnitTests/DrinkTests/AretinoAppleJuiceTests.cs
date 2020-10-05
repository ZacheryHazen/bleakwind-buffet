/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(AAJ);
        }
        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(AAJ);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractDrinkClass()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(AAJ);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Assert.False(AAJ.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Assert.Equal(Size.Small, AAJ.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            AAJ.Ice = false;
            Assert.False(AAJ.Ice);
            AAJ.Ice = true;
            Assert.True(AAJ.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            AAJ.Size = Size.Large;
            Assert.Equal(Size.Large, AAJ.Size);
            AAJ.Size = Size.Medium;
            Assert.Equal(Size.Medium, AAJ.Size);
            AAJ.Size = Size.Small;
            Assert.Equal(Size.Small, AAJ.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            AAJ.Size = size;
            Assert.Equal(price, AAJ.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            AAJ.Size = size;
            Assert.Equal(cal, AAJ.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            AAJ.Ice = includeIce;

            if (includeIce) Assert.Contains("Add ice", AAJ.SpecialInstructions);

            if (!includeIce) Assert.Empty(AAJ.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            AAJ.Size = size;
            Assert.Equal(name, AAJ.ToString());
        }

        [Fact]
        public void ShouldNotifyIfIceChanges()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Assert.PropertyChanged(AAJ, "Ice", () => AAJ.Ice = true);
        }

        [Fact]
        public void ShouldNotifyIfSizeChanges()
        {
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Assert.PropertyChanged(AAJ, "Size", () => AAJ.Size = Size.Large);
        }
    }
}