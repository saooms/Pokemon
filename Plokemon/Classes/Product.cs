using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plokemon.Classes
{
    public class Product
    {
        public int price;
        public string name;
        public object item;

        public Product(object _item, string _name, int _price)
        {
            price = _price;
            name = _name;
            item = _item;
        }
    }
}
