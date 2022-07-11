using System;
using TestTask.Models;
using TestTask.Utils;
namespace TestTask.Interfaces
{
    public interface IResponse
    {
        Person Data { get; }
        public ResponseType responseType { get; set; }
    }
}

