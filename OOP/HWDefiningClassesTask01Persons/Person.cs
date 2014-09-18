// <copyright file="Person.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>

namespace HWDefiningClassesTask01Persons
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private byte age;
        private string mail;

        public Person(string name, byte age, string mail)
        {
            this.Name = name;
            this.Age = age;
            this.Mail = mail;
        }

        public Person(string name, byte age)
            : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name", "Name must be non empty or null!");
                }

                this.name = value;
            }
        }

        public byte Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age must be between 1 and 100!");
                }

                this.age = value;
            }
        }

        public string Mail
        {
            get
            {
                if (string.IsNullOrEmpty(this.mail))
                {
                    return "N/A";
                }

                return this.mail;
            }

            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Mail cannot be empty string and must be valid email or null!", "Mail");
                }

                this.mail = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string name = string.Format("Name: {0}", this.Name);
            string age = string.Format(" Age: {0}", this.Age);
            string mail = string.Format("Mail: {0}", this.Mail);
            int maxLength = this.GetMaxLength(new string[] { name, age, mail });
            sb.AppendLine(string.Format("{0}{1}{2}", '\u2554', new string('\u2550', maxLength), '\u2557'));
            sb.AppendLine(string.Format("{0}{1}{0}", '\u2551', name.PadRight(maxLength, ' ')));
            sb.AppendLine(string.Format("{0}{1}{0}", '\u2551', age.PadRight(maxLength, ' ')));
            sb.AppendLine(string.Format("{0}{1}{0}", '\u2551', mail.PadRight(maxLength, ' ')));
            sb.AppendLine(string.Format("{0}{1}{2}", '\u255A', new string('\u2550', maxLength), '\u255D'));
            return sb.ToString();
        }

        private int GetMaxLength(string[] strings)
        {
            int maxLength = 0;
            foreach (var str in strings)
            {
                if (maxLength < str.Length)
                {
                    maxLength = str.Length;
                }
            }

            return maxLength;
        }
    }
}
