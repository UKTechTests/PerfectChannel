using System;
using PerfectChannel.App.Exceptions;

namespace PerfectChannel.App.Extensions
{
    internal static class StringExtensions
    {
        /// <summary>
        /// Allow some basic validation on input
        /// </summary>
        /// <param name="input"></param>
        /// <param name="expectedLength"></param>
        /// <returns></returns>
        internal static string[] AssertedSplitOnSpace(this string input, int expectedLength)
        {
            var bits = input.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (bits.Length != expectedLength) throw new InvalidInputException(input);

            return bits;
        }

        /// <summary>
        /// Convert compass direction to int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static int ToDirection(this string input)
        {
            switch (input.ToLower())
            {
                case "n":
                    return 0;
                case "e":
                    return 1;
                case "s":
                    return 2;
                case "w":
                    return 3;
                default:
                    throw new InvalidInputException(input);
            }
        }
    }
}