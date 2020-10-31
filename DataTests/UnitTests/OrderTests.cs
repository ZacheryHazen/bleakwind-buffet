/*
 * Author: Zach Hazen
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Xunit;
using BleakwindBuffet.Data;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldBeAssignableFromICollectionInterface()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(order);
        }

        [Fact]
        public void ShouldBeAssignableFromINotifyCollectionChangedInterface()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(order);
        }

        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void SalesTaxShouldBeInitializedCorrectly()
        {
            Order order = new Order();
            Assert.Equal(0.12, order.SalesTaxRate);
        }

        [Fact]
        public void NumberShouldBeInitializedCorrectly()
        {
            Order order = new Order();
            Assert.Equal(Order.nextOrderNumber - 1, order.Number);
        }

        [Fact]
        public void SalesTaxShouldBeAbleToBeSetCorrectly()
        {
            Order order = new Order();
            order.SalesTaxRate = 0.7;
            Assert.Equal(0.7, order.SalesTaxRate);
        }

        [Fact]
        public void CaloriesShouldBeEqualToSumOfOrderItemsCalories()
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            order.Add(BB);
            order.Add(DWF);
            order.Add(AAJ);

            Assert.Equal(BB.Calories + DWF.Calories + AAJ.Calories, order.Calories);
        }

        [Fact]
        public void SubtotalShouldBeEqualToSumOfOrderItemsPrices()
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            order.Add(BB);
            order.Add(DWF);
            order.Add(AAJ);

            Assert.Equal(BB.Price + DWF.Price + AAJ.Price, order.Subtotal);
        }

        [Fact]
        public void TaxShouldBeEqualToTaxMultipliedByOrderItemsSubtotal()
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            order.Add(BB);
            order.Add(DWF);
            order.Add(AAJ);

            Assert.Equal((BB.Price + DWF.Price + AAJ.Price) * order.SalesTaxRate, order.Tax);
        }

        [Fact]
        public void TotalShouldBeEqualToTaxAddedToSubtotal()
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            order.Add(BB);
            order.Add(DWF);
            order.Add(AAJ);

            Assert.Equal((BB.Price + DWF.Price + AAJ.Price) + ((BB.Price + DWF.Price + AAJ.Price) * order.SalesTaxRate), order.Total);
        }

        [Fact]
        public void CountShouldKeepTrackOfOrderItemsCount()
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            order.Add(BB);
            order.Add(DWF);
            order.Add(AAJ);

            Assert.Equal(3, order.Count);
        }

        [Fact]
        public void IndexingShouldAllowYouToRetrieveItems()
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            order.Add(BB);
            order.Add(DWF);
            order.Add(AAJ);

            Assert.Equal(DWF, order[1]);
        }

        [Fact]
        public void IndexingShouldAllowYouToSetItems()
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            order.Add(BB);
            order.Add(DWF);
            order.Add(AAJ);

            order[1] = GOO;

            Assert.Equal(GOO, order[1]);
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void AddingItemsShouldNotify(string propertyChanged)
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();

            Assert.PropertyChanged(order, propertyChanged, () => order.Add(BB));
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void RemovingItemsShouldNotify(string propertyChanged)
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            order.Add(BB);
            if (order.Remove(BB))
            {
                order.Add(BB);
                Assert.PropertyChanged(order, propertyChanged, () => order.Remove(BB));
            }
        }

        [Fact]
        public void FailingToRemoveAnItemShouldReturnFalse()
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();

            Assert.False(order.Remove(BB));
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void ClearingItemsShouldNotify(string propertyChanged)
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            order.Add(BB);
            Assert.PropertyChanged(order, propertyChanged, () => order.Clear());
        }

        [Fact]
        public void NumberShouldIncrementUponClearingOrder()
        {
            Order order = new Order();
            int check = order.Number;
            order.Clear();
            Assert.Equal(check + 1, order.Number);
        }

        [Fact]
        public void NextOrderNumberShouldIncrementUponClearingOrder()
        {
            Order order = new Order();
            int check = Order.nextOrderNumber;
            order.Clear();
            Assert.Equal(check + 1, Order.nextOrderNumber);
        }

        [Fact]
        public void ContainsShouldReturnTrueIfAnOrderContainsAnItem()
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            order.Add(BB);
            Assert.Contains(BB, order);
        }

        [Fact]
        public void ContainsShouldReturnFalseIfAnOrderDoesNotContainAnItem()
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            Assert.DoesNotContain(BB, order);
        }

        [Fact]
        public void CopyToShouldCopyOverAnArrayCorrectly()
        {
            Order order = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            DragonbornWaffleFries DWF = new DragonbornWaffleFries();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            GardenOrcOmelette GOO = new GardenOrcOmelette();
            order.Add(BB);
            order.Add(DWF);
            order.Add(AAJ);
            order.Add(GOO);

            IOrderItem[] test = { BB, DWF, AAJ, GOO };
            IOrderItem[] testCopy = new IOrderItem[4];
            order.CopyTo(testCopy, 0);

            Assert.Equal(test, testCopy);
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void ModifyingAnItemShouldNotifyViaOrder(string propertyChanged)
        {
            Order order = new Order();
            AretinoAppleJuice AAJ = new AretinoAppleJuice();
            order.Add(AAJ);
            Assert.PropertyChanged(order, propertyChanged, () => AAJ.Size = Data.Enums.Size.Large);
        }
    }
}
