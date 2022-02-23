using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211220_SandwichWorld
{
    public class Beverage: Ingredient
    {
        public Beverage(string name,double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
