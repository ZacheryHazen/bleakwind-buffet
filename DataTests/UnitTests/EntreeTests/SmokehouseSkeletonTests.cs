/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(SS);
        }

        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(SS);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractEntreeClass()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(SS);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.True(SS.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.True(SS.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.True(SS.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.True(SS.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            SS.SausageLink = false;
            Assert.False(SS.SausageLink);
            SS.SausageLink = true;
            Assert.True(SS.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            SS.Egg = false;
            Assert.False(SS.Egg);
            SS.Egg = true;
            Assert.True(SS.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            SS.HashBrowns = false;
            Assert.False(SS.HashBrowns);
            SS.HashBrowns = true;
            Assert.True(SS.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            SS.Pancake = false;
            Assert.False(SS.Pancake);
            SS.Pancake = true;
            Assert.True(SS.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.Equal(5.62, SS.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.Equal((double)602, SS.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            SS.SausageLink = includeSausage;
            SS.Egg = includeEgg;
            SS.HashBrowns = includeHashbrowns;
            SS.Pancake = includePancake;

            if (!includeSausage) Assert.Contains("Hold sausage", SS.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", SS.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hashbrowns", SS.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancake", SS.SpecialInstructions);

            if (includeSausage && includeEgg && includeHashbrowns && includePancake) Assert.Empty(SS.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", SS.ToString());
        }

        [Theory]
        [InlineData("SausageLink")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfSausageLinkChanges(string propertyChanged)
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, propertyChanged, () =>SS.SausageLink = false);
        }

        [Theory]
        [InlineData("Egg")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfEggChanges(string propertyChanged)
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, propertyChanged, () => SS.Egg = false);
        }

        [Theory]
        [InlineData("HashBrowns")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfHashBrownsChanges(string propertyChanged)
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, propertyChanged, () => SS.HashBrowns = false);
        }

        [Theory]
        [InlineData("Pancake")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfPancakeChanges(string propertyChanged)
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, propertyChanged, () => SS.Pancake = false);
        }

        [Fact]
        public void ShouldRemoveItemsFromSpecialInstructions()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            SS.SausageLink = false;
            SS.Egg = false;
            SS.HashBrowns = false;
            SS.Pancake = false;
            SS.SausageLink = true;
            SS.Egg = true;
            SS.HashBrowns = true;
            SS.Pancake = true;
            Assert.Empty(SS.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectNameBasedOnToString()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", SS.Name);
        }

        [Fact]
        public void DescriptionShouldReturnTheCorrectString()
        {
            SmokehouseSkeleton SS = new SmokehouseSkeleton();
            Assert.Equal("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.", SS.Description);
        }
    }
}