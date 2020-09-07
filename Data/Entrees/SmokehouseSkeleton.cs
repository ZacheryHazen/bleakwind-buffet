using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Zach Hazen
 * Purpose: Class used to represent the Smokehouse Skeleton entree via various fields and methods.
 */

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class used to represent the Smokehouse Skeleton entree via various fields and methods.
    /// </summary>
    public class SmokehouseSkeleton
    {
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
                sausageLink = value;
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
                egg = value;
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
                hashbrowns = value;
            }
        }

        /// <summary>
        /// If the Smokehouse Skeleton is to be served with pancakes
        /// </summary>
        public bool Pancakes
        {
            get
            {
                return pancake;
            }

            set
            {
                if (value == false)
                {
                    SpecialInstructions.Add("Hold pancakes");
                }
                pancake = value;
            }
        }
        /// <summary>
        /// The price of the Smokehouse Skeleton
        /// </summary>
        public double Price { get; } = 5.62;

        /// <summary>
        /// The calories of the Smokehouse Skeleton
        /// </summary>
        public uint Calories { get; } = 602;

        /// <summary>
        /// A list of special instructions to be used when preparing the Smokehouse Skeleton
        /// </summary>
        public List<string> SpecialInstructions { get; } = new List<string>();

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
