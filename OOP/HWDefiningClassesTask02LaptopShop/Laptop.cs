// <copyright file="Laptop.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>     

namespace HWDefiningClassesTask02LaptopShop
{
    using System;
    using System.Text;
    using HWDefiningClassesTask01Persons;

    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private byte? ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal? batteryLife;
        private decimal price;

        public Laptop(
            string model,
            string manufacturer,
            string processor,
            byte? ram,
            string graphicsCard,
            string hdd,
            string screen,
            Battery battery,
            decimal? batteryLife,
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
            decimal? batteryLife,
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

        public byte? RAM
        {
            get
            {
                return this.ram;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("RAM", "RAM can not be zero");
                }

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

        public decimal? BatteryLife
        {
            get
            {
                return this.batteryLife;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("BatteryLife", "BatteryLife must be positive or zero");
                }

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

        public override string ToString()
        {
            string header = "Laptop description";
            string model = string.Format("model        \u2502{0}", this.Model);
            string manufacturer = string.Format("manufacturer \u2502{0}", this.Manufacturer == null ? "N/A" : this.Manufacturer);
            string processor = string.Format("processor    \u2502{0}", this.Processor == null ? "N/A" : this.Processor);
            string ram = string.Format("RAM          \u2502{0} GB", this.RAM == null ? "N/A" : this.RAM.ToString());
            string graphicsCard = string.Format("graphics card\u2502{0}", this.GraphicsCard == null ? "N/A" : this.GraphicsCard);
            string hdd = string.Format("HDD          \u2502{0}", this.HDD == null ? "N/A" : this.HDD);
            string screen = string.Format("screen       \u2502{0}", this.Screen == null ? "N/A" : this.Screen);
            string battery = string.Format("battery      \u2502{0}", this.Battery == null ? "N/A" : this.Battery.ToString());
            string batteryLife = string.Format("battery life \u2502{0} hours", this.BatteryLife == null ? "N/A" : this.BatteryLife.ToString());
            string price = string.Format("price        \u2502{0:0.00} lv.", this.Price);
            string[] elements = new string[] { header, model, manufacturer, processor, ram, graphicsCard, hdd, screen, battery, batteryLife, price };
            int maxLength = Utils.GetMaxLength(elements);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("\u250C{0}\u2510", new string('\u2500', maxLength)));
            sb.AppendLine(string.Format("\u2502{0}\u2502", header.PadRight(maxLength, ' ')));
            sb.AppendLine(string.Format("\u251C{0}\u252c{1}\u2524", new string('\u2500', 13), new string('\u2500', maxLength - 14)));
            sb.AppendLine(string.Format("\u2502{0}\u2502", model.PadRight(maxLength, ' ')));
            for (int i = 2; i < elements.Length - 1; i++)
            {
                if (!elements[i].Contains("N/A"))
                {
                    sb.AppendLine(string.Format("\u251C{0}\u253c{1}\u2524", new string('\u2500', 13), new string('\u2500', maxLength - 14)));
                    sb.AppendLine(string.Format("\u2502{0}\u2502", elements[i].PadRight(maxLength, ' ')));
                }
            }

            sb.AppendLine(string.Format("\u251C{0}\u253c{1}\u2524", new string('\u2500', 13), new string('\u2500', maxLength - 14)));
            sb.AppendLine(string.Format("\u2502{0}\u2502", price.PadRight(maxLength, ' ')));
            sb.AppendLine(string.Format("\u2514{0}\u2534{1}\u2518", new string('\u2500', 13), new string('\u2500', maxLength - 14)));
            return sb.ToString();
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
