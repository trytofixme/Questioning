using System;
using TestTask.Models;
using TestTask.Utils;
using TestTask.Interfaces;

namespace TestTask.Repository
{
    public class Response : IResponse
    {
        public Person Data { get; private set; }
        public ResponseType responseType { get; set; }

        public Response(ResponseType responseType)
        {
            this.responseType = responseType;
        }

        public Response(ResponseType responseType, Person Data)
        {
            this.Data = Data;
            this.responseType = responseType;
        }

        public Response(Person Data)
        {
            this.Data = Data;
        }

    }
}

