using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldBeAssignableFromIOrderItemInterface()
        {
            Combo combo = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(combo);
        }

        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChangedInterface()
        {
            Combo combo = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(combo);
        }
    }
}