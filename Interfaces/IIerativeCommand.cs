using System;
namespace TestTask.Interfaces
{
    public interface IIerativeCommand

    {
        string CommandName { get; }
        int Execute(int step, string param);
    }


}

