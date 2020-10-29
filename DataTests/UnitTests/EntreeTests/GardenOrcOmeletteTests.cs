/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(GOO);
        }

        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(GOO);
        }

        [Fact]
        public void ShouldBeAssignableFromAbstractEntreeClass()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(GOO);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.True(GOO.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.True(GOO.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.True(GOO.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.True(GOO.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            GOO.Broccoli = false;
            Assert.False(GOO.Broccoli);
            GOO.Broccoli = true;
            Assert.True(GOO.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            GOO.Mushrooms = false;
            Assert.False(GOO.Mushrooms);
            GOO.Mushrooms = true;
            Assert.True(GOO.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            GOO.Tomato = false;
            Assert.False(GOO.Tomato);
            GOO.Tomato = true;
            Assert.True(GOO.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            GOO.Cheddar = false;
            Assert.False(GOO.Cheddar);
            GOO.Cheddar = true;
            Assert.True(GOO.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.Equal(4.57, GOO.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.Equal((double)404, GOO.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            GOO.Broccoli = includeBroccoli;
            GOO.Mushrooms = includeMushrooms;
            GOO.Tomato = includeTomato;
            GOO.Cheddar = includeCheddar;

            if (!includeBroccoli) Assert.Contains("Hold broccoli", GOO.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", GOO.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", GOO.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", GOO.SpecialInstructions);

            if (includeBroccoli && includeMushrooms && includeTomato && includeCheddar) Assert.Empty(GOO.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", GOO.ToString());
        }

        [Theory]
        [InlineData("Broccoli")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfBroccoliChanges(string propertyChanged)
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.PropertyChanged(GOO, propertyChanged, () => GOO.Broccoli = false);
        }

        [Theory]
        [InlineData("Mushrooms")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfMushroomsChanges(string propertyChanged)
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.PropertyChanged(GOO, propertyChanged, () => GOO.Mushrooms = false);
        }

        [Theory]
        [InlineData("Tomato")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfTomatoChanges(string propertyChanged)
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.PropertyChanged(GOO, propertyChanged, () => GOO.Tomato = false);
        }

        [Theory]
        [InlineData("Cheddar")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfCheddarChanges(string propertyChanged)
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.PropertyChanged(GOO, propertyChanged, () => GOO.Cheddar = false);
        }

        [Fact]
        public void ShouldRemoveItemsFromSpecialInstructions()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            GOO.Broccoli = false;
            GOO.Mushrooms = false;
            GOO.Tomato = false;
            GOO.Cheddar = false;
            GOO.Broccoli = true;
            GOO.Mushrooms = true;
            GOO.Tomato = true;
            GOO.Cheddar = true;
            Assert.Empty(GOO.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectNameBasedOnToString()
        {
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", GOO.Name);
        }
    }
}