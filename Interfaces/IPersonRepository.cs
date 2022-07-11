using System;
using TestTask.Models;
namespace TestTask.Interfaces
{
    public interface IPersonRepository
    {
        void Save(Person person);
        void Update(Person person);
        void Delete(string id);
        Person Find(string id);
        IEnumerable<string> ListToday();
        IEnumerable<string> GetAllId();
        IList<Person> GetAll();
    }
}

