using System;
using System.Runtime.Serialization;

namespace Exercises
{
    [Serializable]
    internal class NoEnoughtBalanceException : Exception
    {
        public string Messag { get; set; }
        public NoEnoughtBalanceException()
        {
            Messag = "no enought money";

        }

        public NoEnoughtBalanceException(string message) : base(message)
        {
        }

        public NoEnoughtBalanceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoEnoughtBalanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        public override string ToString()
        {
            return Messag;
        }
    }
}