using System;
using TestTask.Models;
using TestTask.Interfaces;
using TestTask.Utils;
using TestTask.Repository;

namespace TestTask.Commands
{
    public class Save : ICommand
    {
        public string CommandName { get; } = "-save";
        private readonly IPersonRepository profileRepository;

        public Save(IPersonRepository profileRepository)
        {
            this.profileRepository = profileRepository;
        }

        public IResponse Execute(Person profile, string parameter)
        {
            if (profile == null)
                return new Response(new ResponseType(false, false));

            Person Questionnaire = profile;
            profileRepository.Save(profile);
            Console.WriteLine("Анкета сохранена");
            return new Response(new ResponseType(true, true));
        }
    }
}

