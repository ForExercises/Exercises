using System;
using System.Runtime.Serialization;

namespace Exercises
{
    [Serializable]
    internal class NoSuchUserExistException : Exception
    {
        public string Messag { get; set; }
        public NoSuchUserExistException()
        {
            Messag = "No Such a user Exist in User DB";
        }

        public NoSuchUserExistException(string message) : base(message)
        {
        }

        public NoSuchUserExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoSuchUserExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public override string ToString()
        {
            return Messag;
        }
    }
}