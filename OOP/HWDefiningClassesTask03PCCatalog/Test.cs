// <copyright file="Test.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>
      
namespace HWDefiningClassesTask03PCCatalog
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            // Test Component constructors
            Component component1 = new Component("Motherboard", "Asus", 200M);
            Component component2 = new Component("Processor", "Intel i7 4x2Ghz", 250M);
            Component component3 = new Component("RAM", "Kingston 2 X 4GB", 150M);
            Component component4 = new Component("Video card", "Nvidia GTX 660", 180M);
            Component component5 = new Component("HDD", "Western Digital 1TB", 120M);
            Component component6 = new Component("Power supply", "Fortron 500W", 80M);
            Component component7 = new Component("Keyboard", 15M);
            Component component8 = new Component("Mouse", 10M);

            List<Component> components = new List<Component> 
            { 
                component1, component2, component3, component4, component5, component6, component7, component8 
            };

            // Test Computer constructors and My methods :)
            Computer computer3 = new Computer("Stantec3");
            computer3.AddComponent(component1); // Test my methods :) - adding
            computer3.AddComponent(component2); // ...
            computer3.AddComponent(component4);
            computer3.AddComponent(component7);
            computer3.RemoveComponentByName("Keyboard");  // Test my methods :) - removing by name

            Computer computer2 = new Computer("Stantec2");
            computer2.AddComponent(component1);
            computer2.AddComponent(component2);
            computer2.AddComponent(component3);
            computer2.RemoveAllComponents(); // Test my methods :) - clear all
            computer2.AddComponent(component3);
            computer2.AddComponent(component5);
            computer2.AddComponent(component6);
            computer2.AddComponent(component7);
            computer2.AddComponent(component8);
            computer2.AddComponent(component1);

            Computer computer1 = new Computer("Stantec1", components);

            // Testing reference of components - just for test ;)
            component1.Price = 220M; // Now in all computers this part have a new value
            

            // Creating list with computers
            List<Computer> computers = new List<Computer> { computer1, computer2, computer3 };

            // Ordering by price ;) - see Computer class
            computers.Sort();
            
            // Testing Computer info/description method
            foreach (var computer in computers)
            {
                Console.WriteLine(computer.GetDescription());
            }

            // Testing Computer ToString() method
            foreach (var computer in computers)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
