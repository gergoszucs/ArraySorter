using System;

namespace ArraySorter
{
    public class IllegalAlgorithmException : Exception
    {
        public IllegalAlgorithmException()
        {

        }

        public IllegalAlgorithmException(string message) : base(message)
        {

        }

        public IllegalAlgorithmException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
