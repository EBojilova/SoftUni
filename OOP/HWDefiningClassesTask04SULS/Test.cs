﻿// <copyright file="Test.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>

namespace HWDefiningClassesTask04SULS
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            JuniorTrainer juniorTrainer1 = new JuniorTrainer("Pesho", "Peshov", 24);
            JuniorTrainer juniorTrainer2 = new JuniorTrainer("GonlineStudentho", "GonlineStudentov", 27);
            JuniorTrainer juniorTrainer3 = new JuniorTrainer("Vladko", "Vladov", 19);
            SeniorTrainer seniorTrainer1 = new SeniorTrainer("Petko", "Petkov", 33);
            SeniorTrainer seniorTrainer2 = new SeniorTrainer("Stefan", "Stefanov", 38);
            SeniorTrainer seniorTrainer3 = new SeniorTrainer("Martin", "Martinov", 29);
            GraduateStudent graduateStudent1 = new GraduateStudent("Ivan", "Novakov", 35, 30020925, 4.45M);
            GraduateStudent graduateStudent2 = new GraduateStudent("RadonlineStudentlav", "Simeonov", 28, 30058925, 5.80M);
            GraduateStudent graduateStudent3 = new GraduateStudent("Teodor", "Stoychev", 33, 300521345, 3.00M);
            DropoutStudent dropoutStudent1 = new DropoutStudent("Nakovalnq", "Nakovalnev", 35, 30020925, 4.45M, "...");
            DropoutStudent dropoutStudent2 = new DropoutStudent("Mmmm", "IdropOut", 28, 30058925, 5.80M, "I dropoutStudentn't care zzzZZZzzz...");
            DropoutStudent dropoutStudent3 = new DropoutStudent("Arnold", "Ill' be back", 33, 300521345, 3.00M, "Terminated!!!");
            OnlineStudent onlineStudent1 = new OnlineStudent("Emil", "Stefanov", 48, 40018512, 3.33M, "OOP");
            OnlineStudent onlineStudent2 = new OnlineStudent("Martin", "Todorov", 22, 40065415, 5.45M, "OOP");
            OnlineStudent onlineStudent3 = new OnlineStudent("Valeri", "Zahariev", 18, 40018525, 4.89M, "OOP");
            OnsiteStudent onsiteStudent1 = new OnsiteStudent("Natalya", "Alexandrova", 31, 40089564, 4.00M, "OOP", 5);
            OnsiteStudent onsiteStudent2 = new OnsiteStudent("Adriyana", "Alexandrova", 25, 40012188, 5.25M, "OOP", 5);
            OnsiteStudent onsiteStudent3 = new OnsiteStudent("Peter", "Simeonov", 30, 40035698, 3.80M, "OOP", 3);

            juniorTrainer1.CreateCourse("Drink brave!");
           seniorTrainer1.CreateCourse("I'm alive!");
           seniorTrainer2.DeleteCourse("Drink brave!");
            dropoutStudent3.Reapply();

            List<Person> softUniPersons = new List<Person> 
            { 
                juniorTrainer1,
                juniorTrainer2,
                juniorTrainer3,
                seniorTrainer1,
                seniorTrainer2,
                seniorTrainer3,
                graduateStudent1,
                graduateStudent2,
                graduateStudent3,
                dropoutStudent1,
                dropoutStudent2,
                dropoutStudent3,
                onsiteStudent1,
                onsiteStudent2,
                onsiteStudent3,
                onlineStudent1,
                onlineStudent2,
                onlineStudent3 
            };

            SULSTest testSoftUni = new SULSTest(softUniPersons);
            testSoftUni.ExtractCurrentStudents();
        }
    }
}
