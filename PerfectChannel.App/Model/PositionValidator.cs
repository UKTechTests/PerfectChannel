namespace PerfectChannel.App.Model
{
    internal class PositionValidator
    {
        private int Height { get; set; }

        private int Width { get; set; }

        /// <summary>
        /// Dependant on Lawn - in real app IOC would handle init logic
        /// </summary>
        internal PositionValidator()
            : this(Lawn.Height, Lawn.Width)
        {
        }

        /// <summary>
        /// No dependency on Lawn
        /// </summary>
        /// <param name="maxHeight"></param>
        /// <param name="maxWidth"></param>
        internal PositionValidator(int maxHeight, int maxWidth)
        {
            Height = maxHeight;
            Width = maxWidth;
        }

        /// <summary>
        /// Check if x in range
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        internal bool XInRange(int x)
        {
            return x <= Width && x >= 0;
        }

        /// <summary>
        /// Check if y in range
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        internal bool YInRange(int y)
        {
            return y <= Height && y >= 0;
        }
    }
}