using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plokemon.Classes
{
    public class Pikachu : Pokemon
    {

        public Pikachu(string name)
        {
            this.name = name;
            this.type = new EnergyType("Lightning");
            this.hitpoints = 60;
            this.health = 60;
            this.attacks = (Attacks());
            this.weakness = new Weakness("Fire", 1.5);
            this.resistance = new Resistance("Fighting", 20);
        }


        private List<Attack> Attacks()
        {
            // we gaan er nu van uit dat pika alleen deze 2 moves kan hebben, 
            // ander zou het als een parameter moeten worden meegegeven. of via een db

            List<Attack> AList = new List<Attack>();

            AList.Add(new Attack("Electric Ring", 50, this.type));
            AList.Add(new Attack("Pika Punch", 20, this.type));

            return AList;
        }

    }
}
