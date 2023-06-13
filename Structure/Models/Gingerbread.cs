using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChristmasPastryShop.Models
{
    public class Gingerbread : Delicacy
    {
        private const double price = 4.00;
        

        public Gingerbread(string delicacyName) : base(delicacyName, price)
        {
            this.Name = delicacyName;
            this.Price = price;
        }
    }
}
