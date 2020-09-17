/*
 * Author: Zachery Hazen
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            WarriorWater WW = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(WW);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractDrinkClass()
        {
            WarriorWater WW = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(WW);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater WW = new WarriorWater();
            Assert.True(WW.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater WW = new WarriorWater();
            Assert.False(WW.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater WW = new WarriorWater();
            Assert.Equal(Size.Small, WW.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater WW = new WarriorWater();
            WW.Ice = false;
            Assert.False(WW.Ice);
            WW.Ice = true;
            Assert.True(WW.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater WW = new WarriorWater();
            WW.Lemon = true;
            Assert.True(WW.Lemon);
            WW.Lemon = false;
            Assert.False(WW.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater WW = new WarriorWater();
            WW.Size = Size.Large;
            Assert.Equal(Size.Large, WW.Size);
            WW.Size = Size.Medium;
            Assert.Equal(Size.Medium, WW.Size);
            WW.Size = Size.Small;
            Assert.Equal(Size.Small, WW.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater WW = new WarriorWater();
            WW.Size = size;
            Assert.Equal(price, WW.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater WW = new WarriorWater();
            WW.Size = size;
            Assert.Equal(cal, WW.Calories);
        }

        [Theory]
        [InlineData (true, true)]
        [InlineData (true, false)]
        [InlineData (false, true)]
        [InlineData (false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater WW = new WarriorWater();
            WW.Ice = includeIce;
            WW.Lemon = includeLemon;

            if (!includeIce) Assert.Contains("Hold ice", WW.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", WW.SpecialInstructions);

            if (includeIce && !includeLemon) Assert.Empty(WW.SpecialInstructions);
        }

        [Theory]
        [InlineData (Size.Small, "Small Warrior Water")]
        [InlineData (Size.Medium, "Medium Warrior Water")]
        [InlineData (Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater WW = new WarriorWater();
            WW.Size = size;
            Assert.Equal(name, WW.ToString());
        }
    }
}
