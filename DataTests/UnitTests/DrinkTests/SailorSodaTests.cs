/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            SailorSoda SS = new SailorSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(SS);
        }

        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            SailorSoda SS = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(SS);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractDrinkClass()
        {
            SailorSoda SS = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(SS);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda SS = new SailorSoda();
            Assert.True(SS.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda SS = new SailorSoda();
            Assert.Equal(Size.Small, SS.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda SS = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, SS.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda SS = new SailorSoda();
            SS.Ice = false;
            Assert.False(SS.Ice);
            SS.Ice = true;
            Assert.True(SS.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda SS = new SailorSoda();
            SS.Size = Size.Large;
            Assert.Equal(Size.Large, SS.Size);
            SS.Size = Size.Medium;
            Assert.Equal(Size.Medium, SS.Size);
            SS.Size = Size.Small;
            Assert.Equal(Size.Small, SS.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda SS = new SailorSoda();
            SS.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, SS.Flavor);
            SS.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, SS.Flavor);
            SS.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, SS.Flavor);
            SS.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, SS.Flavor);
            SS.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, SS.Flavor);
            SS.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, SS.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda SS = new SailorSoda();
            SS.Size = size;
            Assert.Equal(price, SS.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda SS = new SailorSoda();
            SS.Size = size;
            Assert.Equal(cal, SS.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda SS = new SailorSoda();

            SS.Ice = includeIce;

            if (!includeIce) Assert.Contains("Hold ice", SS.SpecialInstructions);

            if (includeIce) Assert.Empty(SS.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda SS = new SailorSoda();
            SS.Flavor = flavor;
            SS.Size = size;

            Assert.Equal(name, SS.ToString());
        }

        [Fact]
        public void ShouldNotifyIfIceChanges()
        {
            SailorSoda SS = new SailorSoda();
            Assert.PropertyChanged(SS, "Ice", () => SS.Ice = false);
        }

        [Fact]
        public void ShouldNotifyIfSizeChanges()
        {
            SailorSoda SS = new SailorSoda();
            Assert.PropertyChanged(SS, "Size", () => SS.Size = Size.Large);
        }

        [Fact]
        public void ShouldNotifyIfFlavorChanges()
        {
            SailorSoda SS = new SailorSoda();
            Assert.PropertyChanged(SS, "Flavor", () => SS.Flavor = SodaFlavor.Blackberry);
        }
    }
}
