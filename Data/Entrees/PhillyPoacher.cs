﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class PhillyPoacher
    {
        public double Price { get; }

        public uint Calories { get; }

        public List<string> SpecialInstructions { get; }

        public override string ToString()
        {
            return ("Phily Poacher");
        }
    }
}
