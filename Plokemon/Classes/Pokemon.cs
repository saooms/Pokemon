using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plokemon.Classes
{
    class Pokemon
    {
        public string name;
        public EnergyType type;
        public int hitpoints;
        public int health;
        public List<Attack> attacks;
        public Weakness weakness;
        public Resistance resistance;

        public string Attacked(Attack attack)
        {
            string log = "";
            double damage = attack.damage;

            if (this.weakness.type.name == attack.type.name)
            {
                damage *= this.weakness.multiplier;
                log += "it's very effective! \r\n";
            }
            else if (this.resistance.type.name == attack.type.name)
            {
                damage -= this.resistance.value;
                log += "it's not very effective... \r\n";
            }

            log += "the attack did " + damage.ToString() + " dammage to " + this.name + "\r\n";

            log += "his health went from (" + this.health + " / " + this.hitpoints + ") to";
            this.health -= Convert.ToInt32(damage);
            log += " (" + this.health + " / " + this.hitpoints + ") \r\n";

            return log;
        }

    }
}
