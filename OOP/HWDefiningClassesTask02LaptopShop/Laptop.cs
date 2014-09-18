// <copyright file="Laptop.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>     

namespace HWDefiningClassesTask02LaptopShop
{
    using System;
    using System.Text;

    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private string batteryLife;
        private decimal price;

        public Laptop(
            string model,
            string manufacturer,
            string processor,
            string ram,
            string graphicsCard,
            string hdd,
            string screen,
            Battery battery,
            string batteryLife,
            decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
            this.Price = price;
        }

        public Laptop(
            string model,
            Battery battery,
            string batteryLife,
            decimal price)
            : this(model, null, null, null, null, null, null, battery, batteryLife, price)
        {
        }

        public Laptop(string model, decimal price)
            : this(model, null, null, price)
        {
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.ValidateString(value, "Model", true);
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                this.ValidateString(value, "Manufacturer");
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                this.ValidateString(value, "Processor");
                this.processor = value;
            }
        }

        public string RAM
        {
            get
            {
                return this.ram;
            }

            set
            {
                this.ValidateString(value, "RAM");
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }

            set
            {
                this.ValidateString(value, "GraphicsCard");
                this.graphicsCard = value;
            }
        }

        public string HDD
        {
            get
            {
                return this.hdd;
            }

            set
            {
                this.ValidateString(value, "HDD");
                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                this.ValidateString(value, "Screen");
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public string BatteryLife
        {
            get
            {
                return this.batteryLife;
            }

            set
            {
                this.ValidateString(value, "BatteryLife");
                this.batteryLife = value;
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
                    throw new ArgumentOutOfRangeException("Price", "Price must be positive!");
                }

                this.price = value;
            }
        }

        private void ValidateString(string value, string paramName, bool isMandatory = false)
        {
            if (value == string.Empty)
            {
                throw new ArgumentException(string.Format("{0} cannot be empty string!", paramName), paramName);
            }

            if (isMandatory && value == null)
            {
                throw new ArgumentNullException(paramName, string.Format("{0} is mandatory and cannot be null!", paramName));
            }
        }
    }
}
