using System;
using TestTask.Interfaces;
using TestTask.Models;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using TestTask.Utils;
using TestTask.Repository;

namespace TestTask.Commands
{
    public class NewProfile : ICommand
    {
        public string CommandName { get; private set; } = "-new_profile";

        private readonly IDictionary<string, IIerativeCommand> IerativeCmdDict = new Dictionary<string, IIerativeCommand>();
        public NewProfile(IEnumerable<IIerativeCommand> IerativeCmds)
        {
            foreach (var cmd in IerativeCmds)
                IerativeCmdDict.Add(cmd.CommandName, cmd);

        }

        public IResponse Execute(Person SessionPerson, string parameter)
        {
            Person profile = new Person();
            var properties = PropertiesExtractor.GetDisplayProperties(typeof(Person));

            for (int step = 0; step <= (properties.Count() - 1);)
            {
                var property = properties[step];
                var displayAttribute = properties[step].GetCustomAttribute<DisplayAttribute>();
                Console.WriteLine($"{displayAttribute.Order}. {displayAttribute.Prompt ?? displayAttribute.Name}");
                var s = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(s))
                    continue;

                string[] cmdCheckStr = s.Split(" ");
                IIerativeCommand cmd;
                if (IerativeCmdDict.TryGetValue(cmdCheckStr[0], out cmd))
                {
                    // Пришла команда на изменение номера шага
                    var param = s.Substring(cmdCheckStr[0].Length);
                    step = cmd.Execute(step, param);
                }
                else
                {
                    int nextStep = ValidatePropertyValue(profile, property, s);
                    step += nextStep;
                }

            }

            return new Response(new ResponseType(true, false), profile);
        }
        private int ValidatePropertyValue(Person profile, PropertyInfo property, string s)
        {
            try
            {
                var value = Convert.ChangeType(s, property.PropertyType);


                ICollection<ValidationResult> results = new List<ValidationResult>();
                var context = new ValidationContext(profile) { MemberName = property.Name };

                if (!Validator.TryValidateProperty(value, context, results))
                {
                    foreach (var res in results)
                    {
                        Console.WriteLine(res.ErrorMessage);
                    }
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Повторите ввод");
                return 0;
            }
        }
    }
}

