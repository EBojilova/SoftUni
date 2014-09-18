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
    }
}
