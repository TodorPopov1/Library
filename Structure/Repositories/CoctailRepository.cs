using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class CoctailRepository : IRepository<ICocktail>
    {
        private readonly ICollection<ICocktail> cocktailsMenu;
        public CoctailRepository()
        
        { 
            this.cocktailsMenu = new HashSet<ICocktail>();
        }

        public IReadOnlyCollection<ICocktail> Models => (IReadOnlyCollection<ICocktail>) this.cocktailsMenu;

        public void AddModel(ICocktail model)
        {
            cocktailsMenu.Add(model);
        }
    }
}
