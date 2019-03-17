using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plokemon.Classes
{
    public class Player
    {
        public string name;
        public List<Pokemon> fighters;
        public int hearts;

        public Player(string _name, List<Pokemon> _fighters)
        {
            this.name = _name;
            this.fighters = _fighters;
            this.hearts = 0;
        }
    }
}
