using System;
using System.Runtime.Serialization;

namespace Exercises
{
    [Serializable]
    internal class UserNameException : Exception
    {
        public string Messag { get; set; }
        public UserNameException()
        {
            Messag = " user  and  password is  same";
        }

        public UserNameException(string message) : base(message)
        {
        }

        public UserNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public override string ToString()
        {
            return Messag;
        }
    }
}