﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Lunch
    {
        public string Entree { get; set; }
        public string Side { get; set; }
        public string Drink { get; set; }

        public Lunch(string entree, string side, string drink)
        {
            Entree = entree;
            Side = side;
            Drink = drink;
        }
    }
}
