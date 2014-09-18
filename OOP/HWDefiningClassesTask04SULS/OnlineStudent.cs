﻿// <copyright file="OnlineStudent.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>

namespace HWDefiningClassesTask04SULS
{
    using System;

    public class OnlineStudent : CurrentStudent
    {
         public OnlineStudent(string firstName, string lastName, byte age, uint studentNumber, decimal averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
        }
    }
}
