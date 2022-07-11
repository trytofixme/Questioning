﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TestTask.Utils
{
    public class PropertiesExtractor
    {
        public static IList<PropertyInfo> GetDisplayProperties(Type type)
        {
            var allDisplayProperties = type.GetProperties().Where(pi => pi.GetCustomAttributes(typeof(DisplayAttribute), true).Any());
            var properties = new List<PropertyInfo>(allDisplayProperties.OrderBy(p => GetDisplayAttribute(p).Order));
            return properties;
        }

        public static IList<PropertyInfo> GetNotDisplayProperties(Type type)
        {
            var properties = type.GetProperties().Where(pi => !pi.GetCustomAttributes(typeof(DisplayAttribute), true).Any());
            return new List<PropertyInfo>(properties);
        }


        public static DisplayAttribute GetDisplayAttribute(PropertyInfo propertyInfo)
        {
            return propertyInfo.GetCustomAttributes(typeof(DisplayAttribute), false)[0] as DisplayAttribute;
        }
    }
}

