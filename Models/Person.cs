using System;
using System.ComponentModel.DataAnnotations;
using TestTask.Models.ValidationAttributes;

namespace TestTask.Models
{
    public class Person
    {
        [Required]
        [Display(Name = "ФИО", Order = 1)]
        [DataType(DataType.Text, ErrorMessage = "Несоответствие типа данных")]
        [RegularExpression(@"^[а-яА-ЯёЁa-zA-Z0-9\s]+$", ErrorMessage = "Неверный формат ФИО")]
        public string? FullName { get; set; }

        [Required]
        [Display(Name = "Дата рождения", Order = 2)]
        [DataType(DataType.Text, ErrorMessage = "Несоответствие типа данных"))]
        //[CheckFormatAttrubute(ErrorMessage = "Введите дату в формате DD.MM.YYYY")]
        [RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]|(?:Jan|Mar|May|Jul|Aug|Oct|Dec)))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2]|(?:Jan|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec))\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)(?:0?2|(?:Feb))\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9]|(?:Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep))|(?:1[0-2]|(?:Oct|Nov|Dec)))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$")]
        [AgeAttribute(ErrorMessage = "Возраст может быть от 16 до 110")]
        public string? BirthDay { get; set; }

        [Required]
        [Display(Name = "Любимый язык программирования", Order = 3)]
        [DataType(DataType.Text, ErrorMessage = "Несоответствие типа данных")]
        [ProgrammingLanguageAttribute(ErrorMessage = "Введите язык из спика возможных")]// (Можно ввести только указанные варианты, иначе ошибка: PHP, JavaScript, C, C++, Java, C#, Python, Ruby)                
        public string? ProgrammingLanguage { get; set; }

        [Required]
        [Display(Name = "Опыт программирования на указанном языке", Order = 4)]
        [Range(0, 75, ErrorMessage = "Введите реальное число")]
        public int? Experience { get; set; }

        [Required]
        [Display(Name = "Мобильный телефон", Order = 5)]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Несоответствие типа данных")]
        [RegularExpression(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$", ErrorMessage = "Телефон может содержат цифры, пробел и тире и начаниться с +7, 8)")]
        public string? Phone { get; set; }

        //public Person(string FullName, string BirthDay, string ProgrammingLanguage, int Experience, string Phone)
        //{
        //    this.FullName = FullName;
        //    this.BirthDay = BirthDay;
        //    this.ProgrammingLanguage = ProgrammingLanguage;
        //    this.Experience = Experience;
        //    this.Phone = Phone;
        //}
    }
}

