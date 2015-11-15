using PerfectChannel.App.Model;

namespace PerfectChannel.App.Extensions
{
    /// <summary>
    /// Design decision to seperate functionality from POCO class
    /// </summary>
    internal static class MowerExtensions
    {
        /// <summary>
        /// Run commands
        /// </summary>
        /// <param name="mower"></param>
        /// <param name="commands"></param>
        internal static void RunCommand(this Mower mower, string commands)
        {
            var moves = commands.Trim().ToLower().ToCharArray();

            foreach (var command in moves)
            {
                if (command.Equals('l')) 
                    mower.MoveLeft();
                else if (command.Equals('r')) 
                    mower.MoveRight();
                else if (command.Equals('m')) 
                    mower.MoveForward();
            }
        }

        /// <summary>
        /// Move mower right 
        /// </summary>
        /// <param name="mower"></param>
        internal static void MoveRight(this Mower mower)
        {
            if (mower.Direction == 3)
                mower.Direction = 0;
            else
                mower.Direction += 1;
        }

        /// <summary>
        /// Move mower left
        /// </summary>
        /// <param name="mower"></param>
        internal static void MoveLeft(this Mower mower)
        {
            if (mower.Direction == 0)
                mower.Direction = 3;
            else
                mower.Direction -= 1;
        }

        /// <summary>
        /// Move mower 1 step in current direction
        /// </summary>
        /// <param name="mower"></param>
        internal static void MoveForward(this Mower mower)
        {
            switch (mower.Direction)
            {
                case 0:
                    mower.Position.TrySetY(mower.Position.Y + 1);
                    break;
                case 1:
                    mower.Position.TrySetX(mower.Position.X + 1);
                    break;
                case 2:
                    mower.Position.TrySetY(mower.Position.Y - 1);
                    break;
                case 3:
                    mower.Position.TrySetX(mower.Position.X - 1);
                    break;
            }
        }
    }
}