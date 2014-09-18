// <copyright file="Student.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>

namespace HWDefiningClassesTask04SULS
{
    using System;

    public abstract class Student : Person
    {
        private uint studentNumber;
        private decimal averageGrade;

        public Student(string firstName, string lastName, byte age, uint studentNumber, decimal averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public uint StudentNumber
        {
            get 
            { 
                return studentNumber; 
            }

            set 
            {
                if (value > 999999999U)
                {
                    throw new ArgumentOutOfRangeException("StudentNumber", "StudentNumber must be in range 0...999999999");
                }

                studentNumber = value; 
            }
        }

        public decimal AverageGrade
        {
            get 
            { 
                return averageGrade; 
            }

            set 
            {
                if (value > 6M || value < 3M)
                {
                    throw new ArgumentOutOfRangeException("AverageGrade", "AverageGrade must be in range 3...6");
                }

                averageGrade = value; 
            }
        }
    }
}
