using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plokemon.Classes
{
    class Resistance
    {
        public EnergyType type;
        public int value;

        public Resistance(string _type, int _value)
        {
            this.type = new EnergyType(_type);
            this.value = _value;
        }

    }
}
