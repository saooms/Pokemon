using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plokemon.Classes
{
    public class Charmeleon : Pokemon
    {
        public Charmeleon(string name)
        {
            this.name = name;
            this.type = new EnergyType("Fire");
            this.hitpoints = 60;
            this.health = 60;
            this.attacks = Attacks();
            this.weakness = new Weakness("Water", 2);
            this.resistance = new Resistance("Lightning", 10);
        }


        private List<Attack> Attacks()
        {
            // we gaan er nu van uit dat pika alleen deze 2 moves kan hebben, 
            // ander zou het als een parameter moeten worden meegegeven. of via een db

            List<Attack> AList = new List<Attack>();

            AList.Add(new Attack("Head Butt", 10, this.type));
            AList.Add(new Attack("Flare", 30, this.type));

            return AList;
        }
    }
}
