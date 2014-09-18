// <copyright file="Computer.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>
      
namespace HWDefiningClassesTask03PCCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class Computer : IComparable
    {
        private string name;
        private List<Component> components;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        public Computer(string name) : this(name, null)
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
                this.name = value; 
            }
        }

        public List<Component> Components
        {
            get 
            { 
                return this.components; 
            }

            private set 
            {
                if (value == null)
                {
                    this.components = new List<Component>(); 
                }
                else
                {
                    this.components = value; 
                }
            }
        }

        public decimal Price
        {
            get 
            {
                if (this.Components.Count == 0)
                {
                    return 0M;
                }

                return this.Components.Sum(x => x.Price); 
            }
        }

        public bool AddComponent(Component component)
        {
            if (this.Components.Exists(x => x.Name == component.Name))
            {
                return false;
            }

            this.Components.Add(component);
            return true;
        }

        public bool RemoveComponentByName(string componentName)
        {
            int index = this.Components.FindIndex(x => x.Name == componentName);
            if (index < 0)
            {
                return false;
            }

            this.Components.RemoveAt(index);
            return true;
        }

        public void RemoveAllComponents()
        {
            this.Components.Clear();
        }

        public string GetDescription()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('=', 50));
            sb.AppendLine(string.Format("{1}-== Computer {0} ==-", this.Name, new string(' ', (33 - this.Name.Length) / 2)));
            sb.AppendLine("  Components:");
            foreach (var component in this.Components)
            {
                sb.AppendLine(string.Format("    {0}", component));
            }

            sb.AppendLine(new string('-', 50));
            sb.AppendLine(string.Format("Total Computer price is: {0}", this.Price.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG"))));
            sb.AppendLine(new string('=', 50));
            return sb.ToString();
        }

        int IComparable.CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Computer otherComputer = obj as Computer;
            if (otherComputer != null)
            {
                return this.Price.CompareTo(otherComputer.Price);
            }

            throw new ArgumentException("Object is not a Computer!");
        }

        public override string ToString()
        {
            return string.Format("Computer {0} with price: {1}", this.Name, this.Price.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG")));
        }
    }
}
