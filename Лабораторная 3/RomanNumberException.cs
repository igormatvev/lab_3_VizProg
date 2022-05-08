using System;

namespace RomanNumberException_
{
    public class RomanNumberException : Exception
    {
        public short Value { get; }
        public RomanNumberException(string message) : base(message)
        {

        }
    }
}