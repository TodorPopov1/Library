using ChristmasPastryShop.Models.Cocktails.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models
{
    public class Hibernation : Cocktail, ICocktail
    {
        private const double priceOfLargeHibernation = 13.50;
        public Hibernation(string cocktailName, string size) : base(cocktailName, size, priceOfLargeHibernation)
        {
            this.Name = cocktailName;
            this.Size = size;
            this.Price= priceOfLargeHibernation;
        }
    }
}
