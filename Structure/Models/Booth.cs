using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ChristmasPastryShop.Models
{
    
    public class Booth : IBooth
    {
        private int capacity;
        private double currentBill = 0.0;

        private HashSet<Delicacy> delicacyMenu= new HashSet<Delicacy>();
        private HashSet<Cocktail> cocktailMenu= new HashSet<Cocktail>();

        public Booth(int boothID, int capacity) 
        {
            this.BoothId = boothID;
            this.capacity = capacity;
        }
        public int BoothId
        {
            get; private set;
        }

        public int Capacity
        {
            get { return this.capacity; }

            private set
            {
                if (Capacity <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.CapacityLessThanOne);
                }
                else
                {
                    this.capacity= value;
                }
            }
        }

        public IRepository<IDelicacy> DelicacyMenu

        {
            get { return this.DelicacyMenu; }

            set { DelicacyMenu = value; }
            
        }

        public IRepository<ICocktail> CocktailMenu

        {
            get { return this.CocktailMenu; }
            set { this.CocktailMenu = value;}
        }

        public double CurrentBill
        {


            get { return this.CurrentBill; }
            set { this.CurrentBill = 0; }
             
        }

        public double Turnover
        {
            get { return this.Turnover; }
            set
            {
                this.Turnover = 0;
            }
        }

        public bool IsReserved
        {
            get { return this.IsReserved; }
            set { this.IsReserved = false; }

        }

        public void ChangeStatus()
        {
            this.IsReserved = !this.IsReserved;
        }

        public void Charge()
        {
            this.Turnover += CurrentBill;
            currentBill= 0.0;
        }

        public void UpdateCurrentBill(double amount)
        {
            this.CurrentBill += amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Booth: {this.BoothId}");
            sb.AppendLine($"Capacity {this.Capacity}");
            sb.AppendLine($"Turneover: {this.Turnover:f2} lv");
            sb.AppendLine($"-Cocktail menu:");
            foreach (ICocktail cocktail in cocktailMenu)
            {
                sb.AppendLine(cocktail.ToString());
            }
            sb.AppendLine($"-Delicacy menu:");
            foreach (IDelicacy delicacy in delicacyMenu)
            {
                sb.AppendLine(delicacy.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
