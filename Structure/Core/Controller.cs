using ChristmasPastryShop.Core.Contracts;
using ChristmasPastryShop.Models;
using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Core
{
    internal class Controller : IController
    {

        private HashSet<Booth> booths = new HashSet<Booth>();

        public string AddBooth(int capacity)
        {
            
            int numberOfBoots = booths.Count + 1;
            Booth booth = new Booth(numberOfBoots, capacity);
            string returnOutput = $"Added booth number {numberOfBoots} with capacity {capacity} in the pastry shop!";
            return returnOutput;
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {
            throw new NotImplementedException();
        }

        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            

            if (delicacyTypeName == "Gingerbread" && )
            {
                Gingerbread newGingerBread = new Gingerbread(delicacyName);
            }
        }

        public string BoothReport(int boothId)
        {
            throw new NotImplementedException();
        }

        public string LeaveBooth(int boothId)
        {
            throw new NotImplementedException();
        }

        public string ReserveBooth(int countOfPeople)
        {
            throw new NotImplementedException();
        }

        public string TryOrder(int boothId, string order)
        {
            throw new NotImplementedException();
        }
    }
}
