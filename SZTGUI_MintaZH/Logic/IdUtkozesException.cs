using System;
using System.Runtime.Serialization;

namespace SZTGUI_MintaZH.Logic
{
    [Serializable]
    internal class IdUtkozesException : Exception
    {
        public IdUtkozesException()
        {
        }

        public IdUtkozesException(string? message) : base(message)
        {
        }

        public IdUtkozesException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IdUtkozesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}