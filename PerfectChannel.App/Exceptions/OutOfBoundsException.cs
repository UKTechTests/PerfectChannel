using System;

namespace PerfectChannel.App.Exceptions
{
    /// <summary>
    /// Mower is attempting to mow over our rare plants
    /// </summary>
    public class OutOfBoundsException : Exception
    {
         public OutOfBoundsException()
            : base("What are you doing? Watch the rare plants!!!") { }
    }
}