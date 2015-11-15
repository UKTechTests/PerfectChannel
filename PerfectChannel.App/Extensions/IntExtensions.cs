using PerfectChannel.App.Exceptions;

namespace PerfectChannel.App.Extensions
{
    internal static class IntExtensions
    {
        /// <summary>
        /// Convert int value to compass direction
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        internal static string ToCompass(this int direction)
        {
            switch (direction)
            {
                case 0:
                    return "N";
                case 1:
                    return "E";
                case 2:
                    return "S";
                case 3:
                    return "W";
                default:
                    throw new InvalidInputException(direction.ToString());
            }
        }
    }
}