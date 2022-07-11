using System;
using System.ComponentModel.DataAnnotations;

namespace TestTask.Models.ValidationAttributes
{
    public class AgeAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            //value = (DateTime?)value;

            //return DateTime.Now.AddYears(-14).CompareTo(value) >= 0 && DateTime.Now.AddYears(-100).CompareTo(value) <= 0;

            string[] CurrentDate = DateTime.Now.ToString("dd.MM.yyyy").Split('.');
            string[]? BirthDate = value.ToString().Split('.');

            bool Check = Convert.ToInt16(CurrentDate[0]) >= Convert.ToInt16(BirthDate[0]) && Convert.ToInt16(CurrentDate[1]) >= Convert.ToInt16(BirthDate[1]);

            int Years = System.Math.Abs(Convert.ToInt16(CurrentDate[2]) - Convert.ToInt16(BirthDate[2]));
            int Age = Check ? Years : --Years;
            return Age >= 14 && Age <= 110;

        }
    }
}