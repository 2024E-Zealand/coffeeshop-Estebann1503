using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee
        {
            // Overskriv Price-metoden for at returnere den nye pris på en latte
            public override int Price()
            {
                return 40; // Prisen på en latte i danske kroner
            }
        }

    }

