using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class BoothRepository : IRepository<IBooth>
    {
        private readonly ICollection<IBooth> boothsMenu;

        public BoothRepository()
        {
            this.boothsMenu = new HashSet<IBooth>();
        }

        public IReadOnlyCollection<IBooth> Models => (IReadOnlyCollection<IBooth>) this.boothsMenu;

        public void AddModel(IBooth model)
        {
            this.boothsMenu.Add(model);
        }
    }
}
