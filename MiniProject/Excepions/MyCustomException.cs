using System.Runtime.Serialization;

namespace MiniProject.Excepions
{
    public class MyCustomException : Exception
    {
        public MyCustomException()
        {
        }

        //public SameIdException(string message)
        //    : base(message)
        //{
        //}

        public MyCustomException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        [Serializable]
        internal class SameIdException : Exception
        {
            public SameIdException()
            {
            }

            public SameIdException(string? message) : base(message)
            {
            }

            public SameIdException(string? message, Exception? innerException) : base(message, innerException)
            {
            }

            protected SameIdException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}
