using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Zach Hazen
    * Class name: SmokehouseSkeleton.cs
    * Purpose: Class used to represent the Smokehouse Skeleton entree via various fields and methods.
    */
    public class SmokehouseSkeleton
    {
        private bool sausageLink = true;

        private bool egg = true;

        private bool hashbrowns = true;

        private bool pancake = true;
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
                    SpecialInstructions.Add("Hold hash browns");
                }
                hashbrowns = value;
            }
        }

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
        public double Price { get; } = 5.62;

        public uint Calories { get; } = 602;

        public List<string> SpecialInstructions { get; } = new List<string>();

        public override string ToString()
        {
            return ("Smokehouse Skeleton");
        }
    }
}
