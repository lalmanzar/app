﻿using System;

namespace app.utility.extensions
{
    public static class StringExtensions
    {
         public static string format_using(this string template,params string[] elements)
         {
             return string.Format(template, elements);
         }
    }
}