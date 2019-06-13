﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace VCIJSON
{
    public static class TypeExtensions
    {
        public static bool GetIsGenericList(this Type t)
        {
            if (t == null) return false;

            return t.IsGenericType
                   && t.GetGenericTypeDefinition() == typeof(List<>);
        }

        public static bool GetIsGenericDictionary(this Type t)
        {
            if (t == null) return false;

            return t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Dictionary<,>) &&
                   t.GetGenericArguments().FirstOrDefault() == typeof(string);
        }
    }
}