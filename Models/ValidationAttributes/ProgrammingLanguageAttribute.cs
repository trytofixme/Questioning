using System;
using System.ComponentModel.DataAnnotations;
namespace TestTask.Models.ValidationAttributes
{
    public class ProgrammingLanguageAttribute : ValidationAttribute
    {
        public readonly List<string> AllowedLanugages = new() { "PHP", "JavaScript", "C", "C++", "Java", "C#", "Python", "Ruby" };
        public override bool IsValid(object? value)
        {
            return AllowedLanugages.Contains(value);
        }
    }
}

