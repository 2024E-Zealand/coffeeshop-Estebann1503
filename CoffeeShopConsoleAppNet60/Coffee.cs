﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        // Offentlig metode, der returnerer prisen på kaffen
        public virtual int Price()
        {
            return 20; // Prisen på kaffen i danske kroner
        }
    }
}
}
