using PerfectChannel.App.Exceptions;
using PerfectChannel.App.Extensions;
using PerfectChannel.App.Model;

namespace PerfectChannel.App
{
    internal class MowerFactory
    {
        /// <summary>
        /// Validate input and init Mower
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static Mower Init(string input)
        {
            int x;
            int y;

            var args = input.AssertedSplitOnSpace(3);

            if (int.TryParse(args[0], out x) && int.TryParse(args[1], out y))
            {
                return new Mower(x, y, args[2].ToDirection());
            }

            throw new InvalidInputException(input);
        }
    }
}