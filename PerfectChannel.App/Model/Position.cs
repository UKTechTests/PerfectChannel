using PerfectChannel.App.Exceptions;

namespace PerfectChannel.App.Model
{
    internal class Position
    {
        private readonly PositionValidator _validator = new PositionValidator();

        internal int X { get; private set; }

        internal int Y { get; private set; }

        internal Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Try set x value, will throw OutOfBoundsException
        /// </summary>
        /// <param name="x"></param>
        internal void TrySetX(int x)
        {
            if (_validator.XInRange(x)) X = x;
            else throw new OutOfBoundsException();
        }


        /// <summary>
        /// Try set y value, will throw OutOfBoundsException
        /// </summary>
        /// <param name="y"></param>
        internal void TrySetY(int y)
        {
            if (_validator.YInRange(y)) Y = y;
            else throw new OutOfBoundsException();
        }
    }
}