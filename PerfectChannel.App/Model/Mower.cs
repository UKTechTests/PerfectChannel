using PerfectChannel.App.Extensions;

namespace PerfectChannel.App.Model
{
    internal class Mower
    {
        internal int Direction { get; set; }

        internal Position Position { get; set; }

        /// <summary>
        /// Direction 0 = N, 1 = E, 2 = S & 3 = W
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="direction"></param>
        internal Mower(int x, int y, int direction)
        {
            Position = new Position(x, y);
            Direction = direction;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Position.X, Position.Y, Direction.ToCompass());
        }
    }
}