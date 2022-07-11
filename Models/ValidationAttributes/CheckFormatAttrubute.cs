using System;
using System.ComponentModel.DataAnnotations;


namespace TestTask.Models.ValidationAttributes
{
    public class CheckFormatAttrubute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            value = value?.ToString();
            string format = "dd.MM.yyyy";
            var provider = System.Globalization.CultureInfo.InvariantCulture;
            var style = System.Globalization.DateTimeStyles.None;
            DateTime result;     
            if (!DateTime.TryParseExact((string?)value, format, provider, style, out result))
            {
                return false;
            }
            return true;
        }
    }
}

