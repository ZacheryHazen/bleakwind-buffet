using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Thugs T-Bone entree via various fields and methods.
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the Thugs T-Bone entree via various fields and methods.
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The price of the Thugs T-Bone
        /// </summary>
        public override double Price { get; } = 6.44;

        /// <summary>
        /// THe calroies of the Thugs T-Bone
        /// </summary>
        public override uint Calories { get; } = 982;

        /// <summary>
        /// A list of special instructions to be used when preparing the Thugs T-Bone
        /// </summary>
        public override List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Returns a description of the Thugs T-Bone
        /// </summary>
        /// <returns>A string containing the name of the Thugs T-Bone</returns>
        public override string ToString()
        {
            return ("Thugs T-Bone");
        }
    }
}
