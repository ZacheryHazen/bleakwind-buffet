/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            MadOtarGrits MOG = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(MOG);
        }

        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            MadOtarGrits MOG = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(MOG);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractSideClass()
        {
            MadOtarGrits MOG = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(MOG);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits MOG = new MadOtarGrits();
            Assert.Equal(Size.Small, MOG.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits MOG = new MadOtarGrits();
            MOG.Size = Size.Large;
            Assert.Equal(Size.Large, MOG.Size);
            MOG.Size = Size.Medium;
            Assert.Equal(Size.Medium, MOG.Size);
            MOG.Size = Size.Small;
            Assert.Equal(Size.Small, MOG.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits MOG = new MadOtarGrits();
            Assert.Empty(MOG.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits MOG = new MadOtarGrits();
            MOG.Size = size;
            Assert.Equal(price, MOG.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits MOG = new MadOtarGrits();
            MOG.Size = size;
            Assert.Equal(calories, MOG.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits MOG = new MadOtarGrits();
            MOG.Size = size;
            Assert.Equal(name, MOG.ToString());
        }

        [Theory]
        [InlineData("Size")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("Name")]
        public void ShouldNotifyIfSizeChanges(string propertyChanged)
        {
            MadOtarGrits MOG = new MadOtarGrits();
            Assert.PropertyChanged(MOG, propertyChanged, () => MOG.Size = Size.Large);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectNameBasedOnToString(Size size, string name)
        {
            MadOtarGrits MOG = new MadOtarGrits();
            MOG.Size = size;
            Assert.Equal(name, MOG.Name);
        }
    }
}