/*
 * Author: Zach Hazen
 * Class: ComboTests.cs
 * Purpose: Tests the Combo.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            Assert.IsAssignableFrom<IOrderItem>(combo);
        }

        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(combo);
        }

        [Fact]
        public void EntreeShouldBeInitializedCorrectly()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            Assert.Equal(BB, combo.CEntree);
        }

        [Fact]
        public void SideShouldBeInitializedCorrectly()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            Assert.Equal(DWF, combo.CSide);
        }

        [Fact]
        public void DrinkShouldBeInitializedCorrectly()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            Assert.Equal(AAJ, combo.CDrink);
        }

        [Fact]
        public void EntreeShouldBeAbleToBeReassignedCorrectly()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            DoubleDraugr DD = new DoubleDraugr();
            combo.CEntree = DD;
            Assert.Equal(DD, combo.CEntree);
        }

        [Fact]
        public void SideShouldBeAbleToBeReassignedCorrectly()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            FriedMiraak FM = new FriedMiraak();
            combo.CSide = FM;
            Assert.Equal(FM, combo.CSide);
        }

        [Fact]
        public void DrinkShouldBeAbleToBeReassignedCorrectly()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            CandlehearthCoffee CC = new CandlehearthCoffee();
            combo.CDrink = CC;
            Assert.Equal(CC, combo.CDrink);
        }

        [Fact]
        public void PriceShouldBeTheSumOfAllItemPricesMinusOne()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            Assert.Equal(BB.Price + DWF.Price + AAJ.Price - 1, combo.Price);
        }

        [Fact]
        public void CaloriesShouldBeTheSumOfAllItemCalories()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            Assert.Equal(BB.Calories + DWF.Calories + AAJ.Calories, combo.Calories);
        }

        [Fact]
        public void ChangedEntreeShouldNotifyViaCombo()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            
            if (combo.CEntree is BriarheartBurger entreeTest)
            {
                Assert.PropertyChanged(combo, "SpecialInstructions", () => entreeTest.Ketchup = false);
            }   
        }

        [Fact]
        public void ChangedSideShouldNotifyViaCombo()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);

            if (combo.CSide is DragonbornWaffleFries sideTest)
            {
                Assert.PropertyChanged(combo, "Price", () => sideTest.Size = Data.Enums.Size.Large);
            }
        }

        [Fact]
        public void ChangedDrinkShouldNotifyViaCombo()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);

            if (combo.CDrink is AretinoAppleJuice drinkTest)
            {
                Assert.PropertyChanged(combo, "Price", () => drinkTest.Size = Data.Enums.Size.Large);
            }
        }

        [Theory]
        [InlineData("CEntree")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfEntreeChanges(string propertyChanged)
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            DoubleDraugr DD = new DoubleDraugr();

            Assert.PropertyChanged(combo, propertyChanged, () => combo.CEntree = DD);
        }

        [Theory]
        [InlineData("CSide")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfSideChanges(string propertyChanged)
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            FriedMiraak FM = new FriedMiraak();

            Assert.PropertyChanged(combo, propertyChanged, () => combo.CSide = FM);
        }

        [Theory]
        [InlineData("CDrink")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("SpecialInstructions")]
        public void ShouldNotifyIfDrinkChanges(string propertyChanged)
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);
            CandlehearthCoffee CC = new CandlehearthCoffee();

            Assert.PropertyChanged(combo, propertyChanged, () => combo.CDrink = CC);
        }

        [Fact]
        public void SpecialInstructionsShouldBeTheSameAsItemsSpecialInstructionsPlusNames()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);

            BB.Bun = false;
            BB.Cheese = false;
            DWF.Size = Data.Enums.Size.Medium;
            AAJ.Ice = true;
            AAJ.Size = Data.Enums.Size.Large;

            string[] expectedList = { "Briarheart Burger", "Hold bun", "Hold cheese", "Medium Dragonborn Waffle Fries", "Large Aretino Apple Juice", "Add ice" };

            Assert.Equal(expectedList, combo.SpecialInstructions.ToArray());
        }

        [Fact]
        public void DescriptionShouldReturnAConcatenatedStringOfItemsDescriptionDelimitedByNewLines()
        {
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            Combo combo = new Combo(BB, DWF, AAJ);

            Assert.Equal(BB.Description + "\n" + DWF.Description + "\n" + AAJ.Description, combo.Description);
        }
    }
}