// <copyright file="Test.cs" company="Softuni">
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
            JuniorTrainer jt1 = new JuniorTrainer("Pesho", "Peshov", 24);
            JuniorTrainer jt2 = new JuniorTrainer("Gosho", "Goshov", 27);
            JuniorTrainer jt3 = new JuniorTrainer("Vladko", "Vladkov", 19);
            SeniorTrainer st1 = new SeniorTrainer("Petko", "Petkov", 33);
            SeniorTrainer st2 = new SeniorTrainer("Stefan", "Stefanov", 38);
            SeniorTrainer st3 = new SeniorTrainer("Martin", "Martinov", 29);
            GraduateStudent gt1 = new GraduateStudent("Ivan", "Novakov", 35, 30020925, 4.45M);
            GraduateStudent gt2 = new GraduateStudent("Radoslav", "Simeonov", 28, 30058925, 5.80M);
            GraduateStudent gt3 = new GraduateStudent("Teodor", "Stoychev", 33, 300521345, 3.00M);
            DropoutStudent do1 = new DropoutStudent("Nakovalnq", "Nakovalnev", 35, 30020925, 4.45M, "...");
            DropoutStudent do2 = new DropoutStudent("Mmmm", "IdropOut", 28, 30058925, 5.80M, "I don't care zzzZZZzzz...");
            DropoutStudent do3 = new DropoutStudent("Arnold", "Ill' be back", 33, 300521345, 3.00M, "Terminated!!!");
            OnlineStudent ost1 = new OnlineStudent("Emil", "Stefanov", 48, 40018512, 3.33M, "OOP");
            OnlineStudent ost2 = new OnlineStudent("Martin", "Todorov", 22, 40065415, 5.45M, "OOP");
            OnlineStudent ost3 = new OnlineStudent("Valeri", "Zahariev", 18, 40018525, 4.89M, "OOP");
            OnsiteStudent os1 = new OnsiteStudent("Natalya", "Alexandrova", 31, 40089564, 4.00M, "OOP", 5);
            OnsiteStudent os2 = new OnsiteStudent("Adriyana", "Alexandrova", 25, 40012188, 5.25M, "OOP", 5);
            OnsiteStudent os3 = new OnsiteStudent("Peter", "Simeonov", 30, 40035698, 3.80M, "OOP", 3);

            jt1.CreateCourse("Drink brave!");
            st1.CreateCourse("I'm alive!");
            st2.DeleteCourse("Drink brave!");
            do3.Reapply();

            List<Person> softUniPersons = new List<Person> 
            { 
                jt1,
                jt2,
                jt3,
                st1,
                st2,
                st3,
                gt1,
                gt2,
                gt3,
                do1,
                do2,
                do3,
                ost1,
                ost2,
                ost3,
                os1,
                os2,
                os3 
            };

            SULSTest testSoftUni = new SULSTest(softUniPersons);
            testSoftUni.ExtractCurrentStudents();
        }
    }
}
