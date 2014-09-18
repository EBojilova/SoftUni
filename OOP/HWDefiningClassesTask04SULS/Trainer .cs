// <copyright file="Trainer.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>

namespace HWDefiningClassesTask04SULS
{
    using System;

    public abstract class Trainer : Person
    {
        public Trainer(string firstName, string lastName, byte age)
            : base(firstName, lastName, age)
        {
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine(string.Format("You created the course: {0}", courseName));
        }
    }
}
