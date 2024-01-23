using System;
using System.Runtime.Serialization;

namespace Exercises
{
    [Serializable]
    internal class InvalidPasswordException : Exception
    {
        public string Messag { get; set; }
        public InvalidPasswordException()
        {
            Messag = "Your password is  not strong enought";
        }

        public InvalidPasswordException(string message) : base(message)
        {
        }

        public InvalidPasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public override string ToString()
        {
            return Messag;
        }
    }
}
