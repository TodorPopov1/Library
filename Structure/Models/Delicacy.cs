using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChristmasPastryShop.Models
{
    public abstract class Delicacy : IDelicacy
    {
        private string name;
        private double price;
        protected Delicacy(string delicacyName, double price)
        {
            this.Name = delicacyName;
            this.Price = price;
        }

        public string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public double Price
        {
            get { return price; }
            protected set { this.price = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} - {this.Price:f2} lv");
            return sb.ToString().TrimEnd();
        }
    }
}
