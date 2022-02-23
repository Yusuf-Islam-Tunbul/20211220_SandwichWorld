using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211220_SandwichWorld
{
    public class MainIngredient: Ingredient
    {
        public MainIngredient(string name,double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
