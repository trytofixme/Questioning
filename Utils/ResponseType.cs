using System;
namespace TestTask.Utils
{
    public class ResponseType
    {
        public bool Processed = false;
        public bool Empty = false;

        public ResponseType(bool Processed, bool Empty)
        {
            this.Processed = Processed;
            this.Empty = Empty;
        }
    }
}

