﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajapintaExercise
{
    interface IProduct
    {
        Product GetProduct(string name);
        double CalculateTotal();
    }
}
