/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(BB);
        }
        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(BB);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractEntreeClass()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(BB);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.True(BB.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.True(BB.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.True(BB.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.True(BB.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.True(BB.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger BB = new BriarheartBurger();
            BB.Bun = false;
            Assert.False(BB.Bun);
            BB.Bun = true;
            Assert.True(BB.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger BB = new BriarheartBurger();
            BB.Ketchup = false;
            Assert.False(BB.Ketchup);
            BB.Ketchup = true;
            Assert.True(BB.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger BB = new BriarheartBurger();
            BB.Mustard = false;
            Assert.False(BB.Mustard);
            BB.Mustard = true;
            Assert.True(BB.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger BB = new BriarheartBurger();
            BB.Pickle = false;
            Assert.False(BB.Pickle);
            BB.Pickle = true;
            Assert.True(BB.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger BB = new BriarheartBurger();
            BB.Cheese = false;
            Assert.False(BB.Cheese);
            BB.Cheese = true;
            Assert.True(BB.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.Equal(6.32, BB.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.Equal((double)743, BB.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger BB = new BriarheartBurger();
            BB.Bun = includeBun;
            BB.Ketchup = includeKetchup;
            BB.Mustard = includeMustard;
            BB.Pickle = includePickle;
            BB.Cheese = includeCheese;

            if (!includeBun) Assert.Contains("Hold bun", BB.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", BB.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", BB.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", BB.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", BB.SpecialInstructions);

            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese) Assert.Empty(BB.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", BB.ToString());
        }

        [Theory]
        [InlineData("Bun")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfBunChanges(string propertyChanged)
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, propertyChanged, () => BB.Bun = false);
        }

        [Theory]
        [InlineData("Ketchup")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfKetchupChanges(string propertyChanged)
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, propertyChanged, () => BB.Ketchup = false);
        }

        [Theory]
        [InlineData("Mustard")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfMustardChanges(string propertyChanged)
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, propertyChanged, () => BB.Mustard = false);
        }

        [Theory]
        [InlineData("Pickle")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfPickleChanges(string propertyChanged)
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, propertyChanged, () => BB.Pickle = false);
        }

        [Theory]
        [InlineData("Cheese")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfCheeseChanges(string propertyChanged)
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.PropertyChanged(BB, propertyChanged, () => BB.Cheese = false);
        }

        [Fact]
        public void ShouldRemoveItemsFromSpecialInstructions()
        {
            BriarheartBurger BB = new BriarheartBurger();
            BB.Bun = false;
            BB.Ketchup = false;
            BB.Mustard = false;
            BB.Pickle = false;
            BB.Cheese = false;
            BB.Bun = true;
            BB.Ketchup = true;
            BB.Mustard = true;
            BB.Pickle = true;
            BB.Cheese = true;
            Assert.Empty(BB.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectNameBasedOnToString()
        {
            BriarheartBurger BB = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", BB.Name);
        }
    }
}