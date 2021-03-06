﻿/*
 * Author: Zach Hazen
 * Class: MenuTests.cs
 * Purpose: Tests the Menu.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.Linq;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldReturnCorrectItemsFromEntrees()
        {
            List<IOrderItem> orderItems = Menu.Entrees.ToList();
            Assert.Collection(orderItems,
                item => Assert.IsType<BriarheartBurger>(orderItems[0]),
                item => Assert.IsType<DoubleDraugr>(orderItems[1]),
                item => Assert.IsType<GardenOrcOmelette>(orderItems[2]),
                item => Assert.IsType<PhillyPoacher>(orderItems[3]),
                item => Assert.IsType<SmokehouseSkeleton>(orderItems[4]),
                item => Assert.IsType<ThalmorTriple>(orderItems[5]),
                item => Assert.IsType<ThugsTBone>(orderItems[6])
            );
        }

        [Fact]
        public void ShouldReturnCorrectItemTypesFromSides()
        {
            List<IOrderItem> orderItems = Menu.Sides.ToList();
            Assert.Collection(orderItems,
                item => Assert.IsType<DragonbornWaffleFries>(orderItems[0]),
                item => Assert.IsType<DragonbornWaffleFries>(orderItems[1]),
                item => Assert.IsType<DragonbornWaffleFries>(orderItems[2]),
                item => Assert.IsType<FriedMiraak>(orderItems[3]),
                item => Assert.IsType<FriedMiraak>(orderItems[4]),
                item => Assert.IsType<FriedMiraak>(orderItems[5]),
                item => Assert.IsType<MadOtarGrits>(orderItems[6]),
                item => Assert.IsType<MadOtarGrits>(orderItems[7]),
                item => Assert.IsType<MadOtarGrits>(orderItems[8]),
                item => Assert.IsType<VokunSalad>(orderItems[9]),
                item => Assert.IsType<VokunSalad>(orderItems[10]),
                item => Assert.IsType<VokunSalad>(orderItems[11])
            );
        }

        [Fact]
        public void ShouldReturnCorrectItemSizesFromSides()
        {
            List<IOrderItem> orderItems = Menu.Sides.ToList();
            Assert.Collection(orderItems,
                item => Assert.Equal(Size.Small, ((Side)orderItems[0]).Size),
                item => Assert.Equal(Size.Medium, ((Side)orderItems[1]).Size),
                item => Assert.Equal(Size.Large, ((Side)orderItems[2]).Size),
                item => Assert.Equal(Size.Small, ((Side)orderItems[3]).Size),
                item => Assert.Equal(Size.Medium, ((Side)orderItems[4]).Size),
                item => Assert.Equal(Size.Large, ((Side)orderItems[5]).Size),
                item => Assert.Equal(Size.Small, ((Side)orderItems[6]).Size),
                item => Assert.Equal(Size.Medium, ((Side)orderItems[7]).Size),
                item => Assert.Equal(Size.Large, ((Side)orderItems[8]).Size),
                item => Assert.Equal(Size.Small, ((Side)orderItems[9]).Size),
                item => Assert.Equal(Size.Medium, ((Side)orderItems[10]).Size),
                item => Assert.Equal(Size.Large, ((Side)orderItems[11]).Size)
            );
        }

        [Fact]
        public void ShouldReturnCorrectItemTypesFromDrinks()
        {
            List<IOrderItem> orderItems = Menu.Drinks.ToList();
            Assert.Collection(orderItems,
                item => Assert.IsType<AretinoAppleJuice>(orderItems[0]),
                item => Assert.IsType<AretinoAppleJuice>(orderItems[1]),
                item => Assert.IsType<AretinoAppleJuice>(orderItems[2]),
                item => Assert.IsType<CandlehearthCoffee>(orderItems[3]),
                item => Assert.IsType<CandlehearthCoffee>(orderItems[4]),
                item => Assert.IsType<CandlehearthCoffee>(orderItems[5]),
                item => Assert.IsType<MarkarthMilk>(orderItems[6]),
                item => Assert.IsType<MarkarthMilk>(orderItems[7]),
                item => Assert.IsType<MarkarthMilk>(orderItems[8]),
                item => Assert.IsType<SailorSoda>(orderItems[9]),
                item => Assert.IsType<SailorSoda>(orderItems[10]),
                item => Assert.IsType<SailorSoda>(orderItems[11]),
                item => Assert.IsType<SailorSoda>(orderItems[12]),
                item => Assert.IsType<SailorSoda>(orderItems[13]),
                item => Assert.IsType<SailorSoda>(orderItems[14]),
                item => Assert.IsType<SailorSoda>(orderItems[15]),
                item => Assert.IsType<SailorSoda>(orderItems[16]),
                item => Assert.IsType<SailorSoda>(orderItems[17]),
                item => Assert.IsType<SailorSoda>(orderItems[18]),
                item => Assert.IsType<SailorSoda>(orderItems[19]),
                item => Assert.IsType<SailorSoda>(orderItems[20]),
                item => Assert.IsType<SailorSoda>(orderItems[21]),
                item => Assert.IsType<SailorSoda>(orderItems[22]),
                item => Assert.IsType<SailorSoda>(orderItems[23]),
                item => Assert.IsType<SailorSoda>(orderItems[24]),
                item => Assert.IsType<SailorSoda>(orderItems[25]),
                item => Assert.IsType<SailorSoda>(orderItems[26]),
                item => Assert.IsType<WarriorWater>(orderItems[27]),
                item => Assert.IsType<WarriorWater>(orderItems[28]),
                item => Assert.IsType<WarriorWater>(orderItems[29])
            );
        }

        [Fact]
        public void ShouldReturnCorrectItemSizeFromDrinks()
        {
            List<IOrderItem> orderItems = Menu.Drinks.ToList();
            Assert.Collection(orderItems,
                item => Assert.Equal(Size.Small, ((Drink)orderItems[0]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)orderItems[1]).Size),
                item => Assert.Equal(Size.Large, ((Drink)orderItems[2]).Size),
                item => Assert.Equal(Size.Small, ((Drink)orderItems[3]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)orderItems[4]).Size),
                item => Assert.Equal(Size.Large, ((Drink)orderItems[5]).Size),
                item => Assert.Equal(Size.Small, ((Drink)orderItems[6]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)orderItems[7]).Size),
                item => Assert.Equal(Size.Large, ((Drink)orderItems[8]).Size),
                item => Assert.Equal(Size.Small, ((Drink)orderItems[9]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)orderItems[10]).Size),
                item => Assert.Equal(Size.Large, ((Drink)orderItems[11]).Size),
                item => Assert.Equal(Size.Small, ((Drink)orderItems[12]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)orderItems[13]).Size),
                item => Assert.Equal(Size.Large, ((Drink)orderItems[14]).Size),
                item => Assert.Equal(Size.Small, ((Drink)orderItems[15]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)orderItems[16]).Size),
                item => Assert.Equal(Size.Large, ((Drink)orderItems[17]).Size),
                item => Assert.Equal(Size.Small, ((Drink)orderItems[18]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)orderItems[19]).Size),
                item => Assert.Equal(Size.Large, ((Drink)orderItems[20]).Size),
                item => Assert.Equal(Size.Small, ((Drink)orderItems[21]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)orderItems[22]).Size),
                item => Assert.Equal(Size.Large, ((Drink)orderItems[23]).Size),
                item => Assert.Equal(Size.Small, ((Drink)orderItems[24]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)orderItems[25]).Size),
                item => Assert.Equal(Size.Large, ((Drink)orderItems[26]).Size),
                item => Assert.Equal(Size.Small, ((Drink)orderItems[27]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)orderItems[28]).Size),
                item => Assert.Equal(Size.Large, ((Drink)orderItems[29]).Size)
            );
        }

        [Fact]
        public void ShouldReturnCorrectFlavorsFromDrinks()
        {
            List<IOrderItem> orderItems = Menu.Drinks.ToList();
            List<IOrderItem> sailorSodas = new List<IOrderItem>();
            for (int x = 9; x < 27; x++)
            {
                sailorSodas.Add(orderItems[x]);
            }
            Assert.Collection(sailorSodas,
                item => Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)sailorSodas[0]).Flavor),
                item => Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)sailorSodas[1]).Flavor),
                item => Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)sailorSodas[2]).Flavor),
                item => Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)sailorSodas[3]).Flavor),
                item => Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)sailorSodas[4]).Flavor),
                item => Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)sailorSodas[5]).Flavor),
                item => Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)sailorSodas[6]).Flavor),
                item => Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)sailorSodas[7]).Flavor),
                item => Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)sailorSodas[8]).Flavor),
                item => Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)sailorSodas[9]).Flavor),
                item => Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)sailorSodas[10]).Flavor),
                item => Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)sailorSodas[11]).Flavor),
                item => Assert.Equal(SodaFlavor.Peach, ((SailorSoda)sailorSodas[12]).Flavor),
                item => Assert.Equal(SodaFlavor.Peach, ((SailorSoda)sailorSodas[13]).Flavor),
                item => Assert.Equal(SodaFlavor.Peach, ((SailorSoda)sailorSodas[14]).Flavor),
                item => Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)sailorSodas[15]).Flavor),
                item => Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)sailorSodas[16]).Flavor),
                item => Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)sailorSodas[17]).Flavor)
            );
        }

        [Fact]
        public void ShouldReturnCorrectTypesFromFullMenu()
        {
            List<IOrderItem> orderItems = Menu.All.ToList();
            Assert.Collection(orderItems,
                item => Assert.IsType<BriarheartBurger>(orderItems[0]),
                item => Assert.IsType<DoubleDraugr>(orderItems[1]),
                item => Assert.IsType<GardenOrcOmelette>(orderItems[2]),
                item => Assert.IsType<PhillyPoacher>(orderItems[3]),
                item => Assert.IsType<SmokehouseSkeleton>(orderItems[4]),
                item => Assert.IsType<ThalmorTriple>(orderItems[5]),
                item => Assert.IsType<ThugsTBone>(orderItems[6]),
                item => Assert.IsType<DragonbornWaffleFries>(orderItems[7]),
                item => Assert.IsType<DragonbornWaffleFries>(orderItems[8]),
                item => Assert.IsType<DragonbornWaffleFries>(orderItems[9]),
                item => Assert.IsType<FriedMiraak>(orderItems[10]),
                item => Assert.IsType<FriedMiraak>(orderItems[11]),
                item => Assert.IsType<FriedMiraak>(orderItems[12]),
                item => Assert.IsType<MadOtarGrits>(orderItems[13]),
                item => Assert.IsType<MadOtarGrits>(orderItems[14]),
                item => Assert.IsType<MadOtarGrits>(orderItems[15]),
                item => Assert.IsType<VokunSalad>(orderItems[16]),
                item => Assert.IsType<VokunSalad>(orderItems[17]),
                item => Assert.IsType<VokunSalad>(orderItems[18]),
                item => Assert.IsType<AretinoAppleJuice>(orderItems[19]),
                item => Assert.IsType<AretinoAppleJuice>(orderItems[20]),
                item => Assert.IsType<AretinoAppleJuice>(orderItems[21]),
                item => Assert.IsType<CandlehearthCoffee>(orderItems[22]),
                item => Assert.IsType<CandlehearthCoffee>(orderItems[23]),
                item => Assert.IsType<CandlehearthCoffee>(orderItems[24]),
                item => Assert.IsType<MarkarthMilk>(orderItems[25]),
                item => Assert.IsType<MarkarthMilk>(orderItems[26]),
                item => Assert.IsType<MarkarthMilk>(orderItems[27]),
                item => Assert.IsType<SailorSoda>(orderItems[28]),
                item => Assert.IsType<SailorSoda>(orderItems[29]),
                item => Assert.IsType<SailorSoda>(orderItems[30]),
                item => Assert.IsType<SailorSoda>(orderItems[31]),
                item => Assert.IsType<SailorSoda>(orderItems[32]),
                item => Assert.IsType<SailorSoda>(orderItems[33]),
                item => Assert.IsType<SailorSoda>(orderItems[34]),
                item => Assert.IsType<SailorSoda>(orderItems[35]),
                item => Assert.IsType<SailorSoda>(orderItems[36]),
                item => Assert.IsType<SailorSoda>(orderItems[37]),
                item => Assert.IsType<SailorSoda>(orderItems[38]),
                item => Assert.IsType<SailorSoda>(orderItems[39]),
                item => Assert.IsType<SailorSoda>(orderItems[40]),
                item => Assert.IsType<SailorSoda>(orderItems[41]),
                item => Assert.IsType<SailorSoda>(orderItems[42]),
                item => Assert.IsType<SailorSoda>(orderItems[43]),
                item => Assert.IsType<SailorSoda>(orderItems[44]),
                item => Assert.IsType<SailorSoda>(orderItems[45]),
                item => Assert.IsType<WarriorWater>(orderItems[46]),
                item => Assert.IsType<WarriorWater>(orderItems[47]),
                item => Assert.IsType<WarriorWater>(orderItems[48])
            );
        }

        [Fact]
        public void ShouldReturnCorrectSizesFromFullMenu()
        {
            List<IOrderItem> orderItems = Menu.All.ToList();
            List<IOrderItem> sizeItems = new List<IOrderItem>();
            for (int x = 7; x < 49; x++)
            {
                sizeItems.Add(orderItems[x]);
            }
            Assert.Collection(sizeItems,
                item => Assert.Equal(Size.Small, ((Side)sizeItems[0]).Size),
                item => Assert.Equal(Size.Medium, ((Side)sizeItems[1]).Size),
                item => Assert.Equal(Size.Large, ((Side)sizeItems[2]).Size),
                item => Assert.Equal(Size.Small, ((Side)sizeItems[3]).Size),
                item => Assert.Equal(Size.Medium, ((Side)sizeItems[4]).Size),
                item => Assert.Equal(Size.Large, ((Side)sizeItems[5]).Size),
                item => Assert.Equal(Size.Small, ((Side)sizeItems[6]).Size),
                item => Assert.Equal(Size.Medium, ((Side)sizeItems[7]).Size),
                item => Assert.Equal(Size.Large, ((Side)sizeItems[8]).Size),
                item => Assert.Equal(Size.Small, ((Side)sizeItems[9]).Size),
                item => Assert.Equal(Size.Medium, ((Side)sizeItems[10]).Size),
                item => Assert.Equal(Size.Large, ((Side)sizeItems[11]).Size),
                item => Assert.Equal(Size.Small, ((Drink)sizeItems[12]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)sizeItems[13]).Size),
                item => Assert.Equal(Size.Large, ((Drink)sizeItems[14]).Size),
                item => Assert.Equal(Size.Small, ((Drink)sizeItems[15]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)sizeItems[16]).Size),
                item => Assert.Equal(Size.Large, ((Drink)sizeItems[17]).Size),
                item => Assert.Equal(Size.Small, ((Drink)sizeItems[18]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)sizeItems[19]).Size),
                item => Assert.Equal(Size.Large, ((Drink)sizeItems[20]).Size),
                item => Assert.Equal(Size.Small, ((Drink)sizeItems[21]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)sizeItems[22]).Size),
                item => Assert.Equal(Size.Large, ((Drink)sizeItems[23]).Size),
                item => Assert.Equal(Size.Small, ((Drink)sizeItems[24]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)sizeItems[25]).Size),
                item => Assert.Equal(Size.Large, ((Drink)sizeItems[26]).Size),
                item => Assert.Equal(Size.Small, ((Drink)sizeItems[27]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)sizeItems[28]).Size),
                item => Assert.Equal(Size.Large, ((Drink)sizeItems[29]).Size),
                item => Assert.Equal(Size.Small, ((Drink)sizeItems[30]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)sizeItems[31]).Size),
                item => Assert.Equal(Size.Large, ((Drink)sizeItems[32]).Size),
                item => Assert.Equal(Size.Small, ((Drink)sizeItems[33]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)sizeItems[34]).Size),
                item => Assert.Equal(Size.Large, ((Drink)sizeItems[35]).Size),
                item => Assert.Equal(Size.Small, ((Drink)sizeItems[36]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)sizeItems[37]).Size),
                item => Assert.Equal(Size.Large, ((Drink)sizeItems[38]).Size),
                item => Assert.Equal(Size.Small, ((Drink)sizeItems[39]).Size),
                item => Assert.Equal(Size.Medium, ((Drink)sizeItems[40]).Size),
                item => Assert.Equal(Size.Large, ((Drink)sizeItems[41]).Size)
            );
        }

        [Fact]
        public void ShouldReturnCorrectSailorSodaFlavorsFromFullMenu()
        {
            List<IOrderItem> orderItems = Menu.All.ToList();
            List<IOrderItem> sailorSodas = new List<IOrderItem>();
            for (int x = 28; x < 46; x++)
            {
                sailorSodas.Add(orderItems[x]);
            }
            Assert.Collection(sailorSodas,
                item => Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)sailorSodas[0]).Flavor),
                item => Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)sailorSodas[1]).Flavor),
                item => Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)sailorSodas[2]).Flavor),
                item => Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)sailorSodas[3]).Flavor),
                item => Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)sailorSodas[4]).Flavor),
                item => Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)sailorSodas[5]).Flavor),
                item => Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)sailorSodas[6]).Flavor),
                item => Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)sailorSodas[7]).Flavor),
                item => Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)sailorSodas[8]).Flavor),
                item => Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)sailorSodas[9]).Flavor),
                item => Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)sailorSodas[10]).Flavor),
                item => Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)sailorSodas[11]).Flavor),
                item => Assert.Equal(SodaFlavor.Peach, ((SailorSoda)sailorSodas[12]).Flavor),
                item => Assert.Equal(SodaFlavor.Peach, ((SailorSoda)sailorSodas[13]).Flavor),
                item => Assert.Equal(SodaFlavor.Peach, ((SailorSoda)sailorSodas[14]).Flavor),
                item => Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)sailorSodas[15]).Flavor),
                item => Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)sailorSodas[16]).Flavor),
                item => Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)sailorSodas[17]).Flavor)
            );
        }

        [Fact]
        public void NullSearchTermShouldReturnOriginalList()
        {

            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.Search(orderItems, null).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(BB, test[0]),
                item => Assert.Equal(DWF, test[1]),
                item => Assert.Equal(SS, test[2])
            );
        }

        [Fact]
        public void SearchingATermShouldReturnTheCorrectResult()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            ThalmorTriple TT = new ThalmorTriple();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(TT);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.Search(orderItems, "Thalmor").ToList();
            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(TT, test[0])
            );
        }

        [Fact]
        public void SearchingAMultipleTermQueryShouldReturnTheCorrectResultsFromTheTitleAndDescription()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            ThalmorTriple TT = new ThalmorTriple();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(TT);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.Search(orderItems, "patties Dragonborn").ToList();
            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(TT, test[0]),
                item => Assert.Equal(DWF, test[1])
            );
        }

        [Fact]
        public void SearchingAMultipleTermQueryShouldNotReturnDuplicateResults()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            ThalmorTriple TT = new ThalmorTriple();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(TT);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.Search(orderItems, "Dragonborn Dragonborn").ToList();
            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(DWF, test[0])
            );
        }

        [Fact]
        public void NullCategoriesShouldReturnOriginalList()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);
            
            List<IOrderItem> test = Menu.FilterByCategory(orderItems, null).ToList();
            
            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(BB, test[0]),
                item => Assert.Equal(DWF, test[1]),
                item => Assert.Equal(SS, test[2])
            );
        }

        [Fact]
        public void SearchingACategoryShouldReturnTheCorrectResult()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            string[] categories = { "Entrees", "Sides" };
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.FilterByCategory(orderItems, categories).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(BB, test[0]),
                item => Assert.Equal(DWF, test[1])
                );
        }

        [Fact]
        public void NullMinAndMaxPriceShouldReturnOriginalList()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.FilterByPrice(orderItems, null, null).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(BB, test[0]),
                item => Assert.Equal(DWF, test[1]),
                item => Assert.Equal(SS, test[2])
            );
        }

        [Fact]
        public void NullMinPriceShouldReturnUpToMaxPriceOrderItems()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.FilterByPrice(orderItems, null, 2.0).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(DWF, test[0]),
                item => Assert.Equal(SS, test[1])
            );
        }

        [Fact]
        public void NullMaxPriceShouldReturnUpToMinPriceOrderItems()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.FilterByPrice(orderItems, 1.0, null).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(BB, test[0]),
                item => Assert.Equal(SS, test[1])
            );
        }

        [Fact]
        public void SearchingWithMinAndMaxPriceShouldReturnCorrectResults()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.FilterByPrice(orderItems, 0, 2).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(DWF, test[0]),
                item => Assert.Equal(SS, test[1])
            );
        }

        [Fact]
        public void SearchingTheExactPriceShouldReturnTheCorrectResult()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.FilterByPrice(orderItems, 1.42, 1.42).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(SS, test[0])
            );
        }

        [Fact]
        public void NullMinAndMaxCaloriesShouldReturnOriginalList()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.FilterByCalories(orderItems, null, null).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(BB, test[0]),
                item => Assert.Equal(DWF, test[1]),
                item => Assert.Equal(SS, test[2])
            );
        }

        [Fact]
        public void NullMinCaloriesShouldReturnUpToMaxCaloriesOrderItems()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.FilterByCalories(orderItems, null, 200).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(DWF, test[0]),
                item => Assert.Equal(SS, test[1])
            );

        }

        [Fact]
        public void NullMaxCaloriesShouldReturnUpToMinCaloriesOrderItems()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.FilterByCalories(orderItems, 100, null).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(BB, test[0]),
                item => Assert.Equal(SS, test[1])
            );
        }

        [Fact]
        public void SearchingWithMinAndMaxCaloriesShouldReturnCorrectResults()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.FilterByCalories(orderItems, 0, 200).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(DWF, test[0]),
                item => Assert.Equal(SS, test[1])
            );
        }

        [Fact]
        public void SearchingTheExactCalorieValueShouldReturnTheCorrectResult()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            SailorSoda SS = new SailorSoda();

            orderItems.Add(BB);
            orderItems.Add(DWF);
            orderItems.Add(SS);

            List<IOrderItem> test = Menu.FilterByCalories(orderItems, 117, 117).ToList();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal(SS, test[0])
            );
        }
    }
}
