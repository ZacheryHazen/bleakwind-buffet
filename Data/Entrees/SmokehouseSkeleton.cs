using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Smokehouse Skeleton entree via various fields and methods.
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the Smokehouse Skeleton entree via various fields and methods.
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        /// <summary>
        /// The event handler to be used when a specific property changes in the object.
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        // Declaring the private backing variables
        private bool sausageLink = true;

        private bool egg = true;

        private bool hashbrowns = true;

        private bool pancake = true;

        /// <summary>
        /// If the Smokehouse Skeleton is to be served with sausage
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold sausage");
                }
                else
                {
                    SpecialInstructions.Remove("Hold sausage");
                }
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
            }
        }

        /// <summary>
        /// If the Smokehouse Skeleton is to be served with egg
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold eggs");
                }
                else
                {
                    SpecialInstructions.Remove("Hold eggs");
                }
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
            }
        }

        /// <summary>
        /// If the Smokehouse Skeleton is to be served with hashbrowns
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashbrowns;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold hashbrowns");
                }
                else
                {
                    SpecialInstructions.Remove("Hold hashbrowns");
                }
                hashbrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
            }
        }

        /// <summary>
        /// If the Smokehouse Skeleton is to be served with pancakes
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold pancake");
                }
                else
                {
                    SpecialInstructions.Remove("Hold pancake");
                }
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
            }
        }
        /// <summary>
        /// The price of the Smokehouse Skeleton
        /// </summary>
        public override double Price { get; } = 5.62;

        /// <summary>
        /// The calories of the Smokehouse Skeleton
        /// </summary>
        public override uint Calories { get; } = 602;

        /// <summary>
        /// A list of special instructions to be used when preparing the Smokehouse Skeleton
        /// </summary>
        public override List<string> SpecialInstructions { get; } = new List<string>();

        /// <summary>
        /// Simply holds the value of the ToString() method in a string.
        /// </summary>
        public string Name
        {
            get
            {
                return ToString();
            }
        }
        
        /// <summary>
        /// Returns a description of the Smokehouse Skeleton
        /// </summary>
        /// <returns>A string containing the name of the Smokehouse Skeleton</returns>
        public override string ToString()
        {
            return ("Smokehouse Skeleton");
        }
    }
}
