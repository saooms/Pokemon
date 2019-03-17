using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plokemon.Classes
{
    public class Weakness
    {
        public EnergyType type;
        public double multiplier;

        public Weakness(string _type, double _multiplier)
        {
            this.type = new EnergyType(_type);
            this.multiplier = _multiplier;
        }
    }
}

