// <copyright file="SeniorTrainer.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>

namespace HWDefiningClassesTask04SULS
{
    using System;

    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, byte age)
            : base(firstName, lastName, age)
        {
        }

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine(string.Format("You delete a course: {0}", courseName));
        }
    }
}
