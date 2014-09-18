// <copyright file="GraduateStudent.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>

namespace HWDefiningClassesTask04SULS
{
    using System;

    public class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, byte age, uint studentNumber, decimal averageGrade)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
        }
    }
}
