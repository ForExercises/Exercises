using System;
using System.Runtime.Serialization;

namespace Exercises
{
    [Serializable]
    internal class BankRupException : Exception
    {
        public string messag { get; set; }
        public BankRupException()
        {
            messag = "you do not have  a balance and can not use  for services";
        }

        public BankRupException(string message) : base(message)
        {
        }

        public BankRupException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BankRupException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override string ToString()
        {
            return messag;
        }
    }
}