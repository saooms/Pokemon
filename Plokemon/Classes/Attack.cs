using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plokemon.Classes
{
    class Attack
    {
        public string name;
        public int damage;
        public EnergyType type;

        public Attack(string _name, int _damage, EnergyType _type)
        {
            this.name = _name;
            this.damage = _damage;
            this.type = _type;
        }
    }
}
