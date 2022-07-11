using System;
using TestTask.Models;
namespace TestTask.Interfaces
{
    public interface ICommand
    {
        string CommandName { get; }
        IResponse Execute(Person profile, string paramater);
    }
}

