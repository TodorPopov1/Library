using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChristmasPastryShop.Models
{
    public abstract class Cocktail : ICocktail
    {

        private string name;


        public Cocktail(string cocktailName, string size, double price)
        {
            this.name = cocktailName;
            this.Size = size;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
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

        public string Size
        {
            get; set;
        }

        public double Price
        {
            get { return this.Price; }
            set
            {
                switch (this.Size)
                {
                    case "Large":
                    Price = value;
                        break;
                    case "Middle":
                        Price = Math.Round(value *= 66.67 / 100);
                        break;
                    case "Small":
                        Price = Math.Round(value * 33.33 / 100);
                        break;
                    default:
                        break;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} ({this.Size}) - {this.Price:f2} lv");
            return sb.ToString().TrimEnd();
        }
    }
}
