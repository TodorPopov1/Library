using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class DelicacyRepository : IRepository<IDelicacy>
    {

        private readonly ICollection<IDelicacy> delicacyMenu;

        public DelicacyRepository()
        {
            this.delicacyMenu = new HashSet<IDelicacy>();
        }

        public IReadOnlyCollection<IDelicacy> Models => (IReadOnlyCollection<IDelicacy>)this.delicacyMenu;

        public void AddModel(IDelicacy delicacy)
        {
            this.delicacyMenu.Add(delicacy);
        }
    }
}
