// <copyright file="Test.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>

namespace HWDefiningClassesTask02LaptopShop
{
    using System;

    public class Test
    {
        public static void Main()
        {
            // Test Battery constructor
            //Battery testBattery = new Battery(BatteryTypes.NiCdm, 4, -2500); // Not compile
            //Battery testBattery = new Battery(BatteryTypes.NiCdm, -4, 2500); // Not compile
            //Battery testBattery = new Battery("alabala", 4, 2500); // Not compile
            //Battery testBattery = new Battery(BatteryTypes.NiCdm, 4, 0); // Throw exception
            //Battery testBattery = new Battery(BatteryTypes.NiCdm, 0, 2500); // Throw exception
            Battery testBattery = new Battery(BatteryTypes.NiCdm, 4, 2500);

            // Test Laptop constructors
            //Laptop testLaptop = new Laptop("ThinkCentre", -1200.2M); // Throw exception
            //Laptop testLaptop = new Laptop("ThinkCentre", null); // Not Compile
            //Laptop testLaptop = new Laptop("", 1200.2M); // Throw exception
            //Laptop testLaptop = new Laptop(null, 1200.2M); // Throw exception
            Laptop testLaptop1 = new Laptop("ThinkCentre", 1200.2M);
            //Laptop testLaptop2 = new Laptop("ThinkCentre", testBattery, 0, 1200.2M);
            //Laptop testLaptop2 = new Laptop("ThinkCentre", "Battery", 4.8M, 1200.2M);  // Not compile
            //Laptop testLaptop2 = new Laptop("ThinkCentre", testBattery, -4.8M, 1200.2M); // Throw exception
            //Laptop testLaptop2 = new Laptop("ThinkCentre", testBattery, 0, 1200.2M); //OK
            //Laptop testLaptop2 = new Laptop("ThinkCentre", null, null, 1200.2M); //OK
            Laptop testLaptop2 = new Laptop("Inspiron", testBattery, 4.8M, 1200.2M);
            //Laptop testLaptop3 = new Laptop("Pravetz", "", "286", 1, "VGA", "20 MB", "Monochrome", testBattery, 1M, 20M); // Throw exception
            //Laptop testLaptop3 = new Laptop("Pravetz", "Bulgaria", "", 1, "VGA", "20 MB", "Monochrome", testBattery, 1M, 20M); // Throw exception
            //Laptop testLaptop3 = new Laptop("Pravetz", "Bulgaria", "286", 1, "", "20 MB", "Monochrome", testBattery, 1M, 20M); // Throw exception
            //Laptop testLaptop3 = new Laptop("Pravetz", "Bulgaria", "286", 1, "VGA", "", "Monochrome", testBattery, 1M, 20M); // Throw exception
            //Laptop testLaptop3 = new Laptop("Pravetz", "Bulgaria", "286", 1, "VGA", "20 MB", "", testBattery, 1M, 20M); // Throw exception
            //Laptop testLaptop3 = new Laptop("Pravetz", "Bulgaria", "286", -1, "VGA", "20 MB", "Monochrome", testBattery, 1M, 20M); // Not compile
            //Laptop testLaptop3 = new Laptop("Pravetz", null, null, null, null, null, null, null, null, 20M); // OK
            Laptop testLaptop3 = new Laptop("Pravetz", "Bulgaria", "286", 1, "VGA", "20 MB", "Monochrome", testBattery, 1M, 20M);
            Laptop testLaptop4 = new Laptop("Pravetz", "Bulgaria", null, 1, "VGA", "20 MB", null, testBattery, 1M, 20M);

            // Test Battery ToString() method
            Console.WriteLine(testBattery);

            // Test Laptop ToString() method
            Console.WriteLine(testLaptop1);
            Console.WriteLine(testLaptop2);
            Console.WriteLine(testLaptop3);
            Console.WriteLine(testLaptop4);
        }
    }
}
