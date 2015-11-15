namespace PerfectChannel.App.Model
{
    internal static class Lawn
    {
        internal static int Height { get; private set; }

        internal static int Width { get; private set; }

        internal static void Initialise(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}