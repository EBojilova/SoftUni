// <copyright file="Test.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>
      
namespace DefiningClassesTask01Persons
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Person[] persons = new Person[2];

            // Test constructor
            // persons[0] = new Person(); //not compile
            persons[0] = new Person("Pesho", 21, "peshoviq@mail.com");
            persons[1] = new Person("Gosho", 43);

            // Test ToString()
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

            // Test name validation:
            // persons[0].Name = ""; //throw exception
            // persons[0].Name = null; //throw exception
            persons[0].Name = "New Pesho";

            // Test age validation
            // persons[0].Age = 0; //throw exception
            // persons[0].Age = 101; //throw exception
            persons[0].Age = 1;
            persons[0].Age = 100;

            // Test mail validation
            // persons[0].Mail = ""; //throw exception
            // persons[0].Mail = "invalid.mail.com"; //throw exception
            persons[0].Mail = null;
            persons[0].Mail = "valid@mail.com";
        }
    }
}
