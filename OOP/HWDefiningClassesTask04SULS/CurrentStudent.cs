// <copyright file="CurrentStudent.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>

namespace HWDefiningClassesTask04SULS
{
    using System;
    using System.Text;
    using HWDefiningClassesTask01Persons;

    public abstract class CurrentStudent : Student
    {
        private string currentCourse;

        public CurrentStudent(string firstName, string lastName, byte age, uint studentNumber, decimal averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get
            {
                return currentCourse;
            }

            set
            {
                Utils.ValidateString(value, "CurrentCourse", true);
                currentCourse = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

        }
    }
}
