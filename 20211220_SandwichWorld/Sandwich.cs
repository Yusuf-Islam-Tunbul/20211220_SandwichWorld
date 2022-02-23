using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211220_SandwichWorld
{
    public class Sandwich
    {
        private double _size;
        private int _amount;
        private bool _is_hollow;
        private Bread _bread;
        private MainIngredient _main_ingredient;
        private Beverage _beverage;
        private List<ExtraIngredient> _extra_ingredients=new List<ExtraIngredient>();

        public double Size
        {
            get { return this._size; }
            set { this._size = value; }
        }
        public int Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        public bool IsHollow
        {
            get { return this._is_hollow; }
            set { this._is_hollow = value; }
        }

        public Bread Bread
        {
            get { return this._bread; }
            set { this._bread = value; }
        }

        public MainIngredient MainIngredient
        {
            get { return this._main_ingredient; }
            set { this._main_ingredient= value; }
        }

        public Beverage Beverage
        {
            get { return this._beverage; }
            set { this._beverage = value; }
        }

        public List<ExtraIngredient> ExtraIngredients
        {
            get { return this._extra_ingredients; }
            set { this._extra_ingredients=value; }
        }

        public Sandwich()
        {
            this.Amount = 1;
        }

        public double CalculatePrice()
        {
            double price = 0;
            price += this.Bread.Price;
            price += this.MainIngredient.Price;    
            foreach (ExtraIngredient extra_ingredient in ExtraIngredients)
            {
                price += extra_ingredient.Price;
            }
            price = this.Size * price;
            price += this.Beverage.Price;
            price = this.Amount * price;
            return price;
        }
    }
}
