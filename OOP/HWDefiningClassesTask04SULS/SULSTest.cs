// <copyright file="SULSTest.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>

namespace HWDefiningClassesTask04SULS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SULSTest
    {
        private List<Person> softUniPersons;

        public SULSTest(List<Person> softUniPersons)
        {
            this.SoftUniPersons = softUniPersons;
        }

        public List<Person> SoftUniPersons
        {
            get 
            { 
                return this.softUniPersons; 
            }

            set 
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("SoftUniPersons can not be null or empty!", "SoftUniPersons");
                }

                this.softUniPersons = value; 
            }
        }

        public void ExtractCurrentStudents()
        {
            IEnumerable<CurrentStudent> currentStudents = this.SoftUniPersons.Where(x => x is CurrentStudent).Cast<CurrentStudent>().Select(x => x);
            currentStudents = currentStudents.OrderByDescending(student => student.AverageGrade);
            int count = 0;
            foreach (var student in currentStudents)
            {
                count++;
                Console.WriteLine(string.Format("Student {0}\n{1}", count, student));
            }
        }
    }
}
