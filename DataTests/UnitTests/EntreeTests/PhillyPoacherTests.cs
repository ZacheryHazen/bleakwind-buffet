/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Net.Sockets;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(PP);
        }

        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(PP);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractEntreeClass()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(PP);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.True(PP.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.True(PP.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.True(PP.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher PP = new PhillyPoacher();
            PP.Sirloin = false;
            Assert.False(PP.Sirloin);
            PP.Sirloin = true;
            Assert.True(PP.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher PP = new PhillyPoacher();
            PP.Onion = false;
            Assert.False(PP.Onion);
            PP.Onion = true;
            Assert.True(PP.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher PP = new PhillyPoacher();
            PP.Roll = false;
            Assert.False(PP.Roll);
            PP.Roll = true;
            Assert.True(PP.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.Equal(7.23, PP.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.Equal((double)784, PP.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher PP = new PhillyPoacher();
            PP.Sirloin = includeSirloin;
            PP.Onion = includeOnion;
            PP.Roll = includeRoll;

            if (!PP.Sirloin) Assert.Contains("Hold sirloin", PP.SpecialInstructions);
            if (!PP.Onion) Assert.Contains("Hold onions", PP.SpecialInstructions);
            if (!PP.Roll) Assert.Contains("Hold roll", PP.SpecialInstructions);

            if (PP.Sirloin && PP.Onion && PP.Roll) Assert.Empty(PP.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.Equal("Philly Poacher", PP.ToString());
        }

        [Fact]
        public void ShouldNotifyIfSirloinChanges()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.PropertyChanged(PP, "Sirloin", () => PP.Sirloin = false);
        }

        [Fact]
        public void ShouldNotifyIfOnionChanges()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.PropertyChanged(PP, "Onion", () => PP.Onion = false);
        }

        [Fact]
        public void ShouldNotifyIfRollChanges()
        {
            PhillyPoacher PP = new PhillyPoacher();
            Assert.PropertyChanged(PP, "Roll", () => PP.Roll = false);
        }
    }
}