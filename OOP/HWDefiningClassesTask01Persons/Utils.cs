// <copyright file="Utils.cs" company="Softuni">
// Copyright (c) 2014 All Rights Reserved
// <author>Me</author>
// </copyright>

namespace HWDefiningClassesTask01Persons
{
    using System;

    public static class Utils
    {
        public static int GetMaxLength(string[] strings)
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

        public static void ValidateString(string value, string paramName, bool isMandatory = false)
        {
            if (value == string.Empty)
            {
                throw new ArgumentException(string.Format("{0} cannot be empty string!", paramName), paramName);
            }

            if (isMandatory && value == null)
            {
                throw new ArgumentNullException(paramName, string.Format("{0} is mandatory and cannot be null!", paramName));
            }
        }
    }
}