/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            MarkarthMilk MM = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(MM);
        }

        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            MarkarthMilk MM = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(MM);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractDrinkClass()
        {
            MarkarthMilk MM = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(MM);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk MM = new MarkarthMilk();
            Assert.False(MM.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk MM = new MarkarthMilk();
            Assert.Equal(Size.Small, MM.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk MM = new MarkarthMilk();
            MM.Ice = true;
            Assert.True(MM.Ice);
            MM.Ice = false;
            Assert.False(MM.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk MM = new MarkarthMilk();
            MM.Size = Size.Large;
            Assert.Equal(Size.Large, MM.Size);
            MM.Size = Size.Medium;
            Assert.Equal(Size.Medium, MM.Size);
            MM.Size = Size.Small;
            Assert.Equal(Size.Small, MM.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk MM = new MarkarthMilk();
            MM.Size = size;
            Assert.Equal(price, MM.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk MM = new MarkarthMilk();
            MM.Size = size;
            Assert.Equal(cal, MM.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk MM = new MarkarthMilk();
            MM.Ice = includeIce;

            if (includeIce) Assert.Contains("Add ice", MM.SpecialInstructions);

            if (!includeIce) Assert.Empty(MM.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk MM = new MarkarthMilk();

            MM.Size = size;

            Assert.Equal(name, MM.ToString());
        }

        [Fact]
        public void ShouldNotifyIfIceChanges()
        {
            MarkarthMilk MM = new MarkarthMilk();
            Assert.PropertyChanged(MM, "Ice", () => MM.Ice = false);
        }

        [Fact]
        public void ShouldNotifyIfSizeChanges()
        {
            MarkarthMilk MM = new MarkarthMilk();
            Assert.PropertyChanged(MM, "Size", () => MM.Size = Size.Large);
        }
    }
}