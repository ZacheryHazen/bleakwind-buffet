/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(TT);
        }

        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(TT);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractEntreeClass()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(TT);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.True(TT.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Bun = false;
            Assert.False(TT.Bun);
            TT.Bun = true;
            Assert.True(TT.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Ketchup = false;
            Assert.False(TT.Ketchup);
            TT.Ketchup = true;
            Assert.True(TT.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Mustard = false;
            Assert.False(TT.Mustard);
            TT.Mustard = true;
            Assert.True(TT.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Pickle = false;
            Assert.False(TT.Pickle);
            TT.Pickle = true;
            Assert.True(TT.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Cheese = false;
            Assert.False(TT.Cheese);
            TT.Cheese = true;
            Assert.True(TT.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Tomato = false;
            Assert.False(TT.Tomato);
            TT.Tomato = true;
            Assert.True(TT.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Lettuce = false;
            Assert.False(TT.Lettuce);
            TT.Lettuce = true;
            Assert.True(TT.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Mayo = false;
            Assert.False(TT.Mayo);
            TT.Mayo = true;
            Assert.True(TT.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Bacon = false;
            Assert.False(TT.Bacon);
            TT.Bacon = true;
            Assert.True(TT.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Egg = false;
            Assert.False(TT.Egg);
            TT.Egg = true;
            Assert.True(TT.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.Equal(8.32, TT.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.Equal((double)943, TT.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Bun = includeBun;
            TT.Ketchup = includeKetchup;
            TT.Mustard = includeMustard;
            TT.Pickle = includePickle;
            TT.Cheese = includeCheese;
            TT.Tomato = includeTomato;
            TT.Lettuce = includeLettuce;
            TT.Mayo = includeMayo;
            TT.Bacon = includeBacon;
            TT.Egg = includeEgg;

            if (!includeBun) Assert.Contains("Hold bun", TT.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", TT.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", TT.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", TT.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", TT.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", TT.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", TT.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", TT.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", TT.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", TT.SpecialInstructions);

            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce && includeMayo && includeBacon && includeEgg) Assert.Empty(TT.SpecialInstructions);

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", TT.ToString());
        }

        [Theory]
        [InlineData("Bun")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfBunChanges(string propertyChanged)
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, propertyChanged, () => TT.Bun = false);
        }

        [Theory]
        [InlineData("Ketchup")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfKetchupChanges(string propertyChanged)
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, propertyChanged, () => TT.Ketchup = false);
        }

        [Theory]
        [InlineData("Mustard")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfMustardChanges(string propertyChanged)
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, propertyChanged, () => TT.Mustard = false);
        }

        [Theory]
        [InlineData("Pickle")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfPickleChanges(string propertyChanged)
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, propertyChanged, () => TT.Pickle = false);
        }

        [Theory]
        [InlineData("Cheese")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfCheeseChanges(string propertyChanged)
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, propertyChanged, () => TT.Cheese = false);
        }

        [Theory]
        [InlineData("Tomato")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfTomatoChanges(string propertyChanged)
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, propertyChanged, () => TT.Tomato = false);
        }

        [Theory]
        [InlineData("Lettuce")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfLettuceChanges(string propertyChanged)
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, propertyChanged, () => TT.Lettuce = false);
        }

        [Theory]
        [InlineData("Mayo")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfMayoChanges(string propertyChanged)
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, propertyChanged, () => TT.Mayo = false);
        }

        [Theory]
        [InlineData("Bacon")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfBaconChanges(string propertyChanged)
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, propertyChanged, () => TT.Bacon = false);
        }

        [Theory]
        [InlineData("Egg")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfEggChanges(string propertyChanged)
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, propertyChanged, () => TT.Egg = false);
        }

        [Fact]
        public void ShouldRemoveItemsFromSpecialInstructions()
        {
            ThalmorTriple TT = new ThalmorTriple();
            TT.Bun = false;
            TT.Ketchup = false;
            TT.Mustard = false;
            TT.Pickle = false;
            TT.Cheese = false;
            TT.Tomato = false;
            TT.Lettuce = false;
            TT.Mayo = false;
            TT.Bacon = false;
            TT.Egg = false;
            TT.Bun = true;
            TT.Ketchup = true;
            TT.Mustard = true;
            TT.Pickle = true;
            TT.Cheese = true;
            TT.Tomato = true;
            TT.Lettuce = true;
            TT.Mayo = true;
            TT.Bacon = true;
            TT.Egg = true;
            Assert.Empty(TT.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectNameBasedOnToString()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", TT.Name);
        }

        [Fact]
        public void DescriptionShouldReturnTheCorrectString()
        {
            ThalmorTriple TT = new ThalmorTriple();
            Assert.Equal("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.", TT.Description);
        }
    }
}