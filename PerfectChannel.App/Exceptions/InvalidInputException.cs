using System;

namespace PerfectChannel.App.Exceptions
{
    /// <summary>
    /// User input invalid.
    /// Either could not parse or invalid arg count.
    /// </summary>
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string input)
            : base(string.Format("Invalid value. Unable to parse {0}", input)) { }
    }
}