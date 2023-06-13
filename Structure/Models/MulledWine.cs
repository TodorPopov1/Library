using ChristmasPastryShop.Models.Cocktails.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models
{
    public class MulledWine : Cocktail, ICocktail
    {
        private const double priceOfLargeMulledWine = 13.50;
        public MulledWine(string cocktailName, string size) : base(cocktailName, size, priceOfLargeMulledWine)
        {
            this.Name = cocktailName;
            this.Size = size;
            this.Price = priceOfLargeMulledWine;
        }
    }
}
