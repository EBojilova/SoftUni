// <copyright file="Component.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>
      
namespace HWDefiningClassesTask03PCCatalog
{
    using System;
    using System.Globalization;
    using HWDefiningClassesTask01Persons;

    public class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, decimal price) : this(name, null, price)
        {
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            private set 
            {
                Utils.ValidateString(value, "Name", true);
                this.name = value; 
            }
        }

        public string Details
        {
            get 
            { 
                return this.details; 
            }

            set 
            {
                Utils.ValidateString(value, "Details");
                this.details = value; 
            }
        }

        public decimal Price
        {
            get 
            { 
                return this.price; 
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price must be positive value!");
                }

                this.price = value; 
            }
        }

        public override string ToString()
        {
            return string.Format(
                "{0} - {1} ---> {2}", 
                this.Name, 
                this.Details == null ? "no name" : this.Details, 
                this.Price.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG")));
        }
    }
}
