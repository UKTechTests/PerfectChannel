using System;

namespace PerfectChannel.App
{
    public class Program
    {
        private static bool _isInitialised;

        private static bool _isDeploying = true;

        public static void Main(string[] args)
        {
            var app = new Application();

            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input)) return;

                if (!_isInitialised)
                {
                    app.InitLawn(input);

                    _isInitialised = true;

                    continue;
                }

                if (_isDeploying)
                {
                    app.InitMower(input);
                }
                else
                {
                    Console.WriteLine(app.RunCommand(input));
                }

                _isDeploying = !_isDeploying;
            }
        }
    }
}
