/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(DD);
        }

        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(DD);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractEntreeClass()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(DD);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.True(DD.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.True(DD.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.True(DD.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.True(DD.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.True(DD.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.True(DD.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.True(DD.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.True(DD.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr DD = new DoubleDraugr();
            DD.Bun = false;
            Assert.False(DD.Bun);
            DD.Bun = true;
            Assert.True(DD.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr DD = new DoubleDraugr();
            DD.Ketchup = false;
            Assert.False(DD.Ketchup);
            DD.Ketchup = true;
            Assert.True(DD.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr DD = new DoubleDraugr();
            DD.Mustard = false;
            Assert.False(DD.Mustard);
            DD.Mustard = true;
            Assert.True(DD.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr DD = new DoubleDraugr();
            DD.Pickle = false;
            Assert.False(DD.Pickle);
            DD.Pickle = true;
            Assert.True(DD.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr DD = new DoubleDraugr();
            DD.Cheese = false;
            Assert.False(DD.Cheese);
            DD.Cheese = true;
            Assert.True(DD.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr DD = new DoubleDraugr();
            DD.Tomato = false;
            Assert.False(DD.Tomato);
            DD.Tomato = true;
            Assert.True(DD.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr DD = new DoubleDraugr();
            DD.Lettuce = false;
            Assert.False(DD.Lettuce);
            DD.Lettuce = true;
            Assert.True(DD.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr DD = new DoubleDraugr();
            DD.Mayo = false;
            Assert.False(DD.Mayo);
            DD.Mayo = true;
            Assert.True(DD.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.Equal(7.32, DD.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.Equal((double)843, DD.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr DD = new DoubleDraugr();

            DD.Bun = includeBun;
            DD.Ketchup = includeKetchup;
            DD.Mustard = includeMustard;
            DD.Pickle = includePickle;
            DD.Cheese = includeCheese;
            DD.Tomato = includeTomato;
            DD.Lettuce = includeLettuce;
            DD.Mayo = includeMayo;

            if (!includeBun) Assert.Contains("Hold bun", DD.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", DD.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", DD.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", DD.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", DD.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", DD.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", DD.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", DD.SpecialInstructions);

            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce && includeMayo) Assert.Empty(DD.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.Equal("Double Draugr", DD.ToString());
        }

        [Fact]
        public void ShouldNotifyIfBunChanges()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Bun", () => DD.Bun = false);
        }

        [Fact]
        public void ShouldNotifyIfKetchupChanges()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Ketchup", () => DD.Ketchup = false);
        }

        [Fact]
        public void ShouldNotifyIfMustardChanges()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Mustard", () => DD.Mustard = false);
        }

        [Fact]
        public void ShouldNotifyIfPickleChanges()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Pickle", () => DD.Pickle = false);
        }

        [Fact]
        public void ShouldNotifyIfCheeseChanges()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Cheese", () => DD.Cheese = false);
        }

        [Fact]
        public void ShouldNotifyIfTomatoChanges()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Tomato", () => DD.Tomato = false);
        }

        [Fact]
        public void ShouldNotifyIfLettuceChanges()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Lettuce", () => DD.Lettuce = false);
        }

        [Fact]
        public void ShouldNotifyIfMayoChanges()
        {
            DoubleDraugr DD = new DoubleDraugr();
            Assert.PropertyChanged(DD, "Mayo", () => DD.Mayo = false);
        }
    }
}