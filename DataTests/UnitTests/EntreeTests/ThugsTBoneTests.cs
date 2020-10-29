/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            ThugsTBone TTB = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(TTB);
        }

        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            ThugsTBone TTB = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(TTB);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractEntreeClass()
        {
            ThugsTBone TTB = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(TTB);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone TTB = new ThugsTBone();
            Assert.Equal(6.44, TTB.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone TTB = new ThugsTBone();
            Assert.Equal((double)982, TTB.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone TTB = new ThugsTBone();
            Assert.Empty(TTB.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone TTB = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", TTB.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectNameBasedOnToString()
        {
            ThugsTBone TTB = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", TTB.Name);
        }
    }
}