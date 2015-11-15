using PerfectChannel.App.Exceptions;
using PerfectChannel.App.Extensions;
using PerfectChannel.App.Model;

namespace PerfectChannel.App
{
    internal static class LawnInitialiser
    {
        /// <summary>
        /// Validate input and init Lawn
        /// </summary>
        /// <param name="input"></param>
        internal static void Init(string input)
        {
            int height;
            int width;

            var coords = input.AssertedSplitOnSpace(2);

            if (int.TryParse(coords[0], out height) && int.TryParse(coords[1], out width))
                Lawn.Initialise(height, width);
            else
                throw new InvalidInputException(input);
        }
    }
}