using System;
using PerfectChannel.App.Extensions;
using PerfectChannel.App.Model;

namespace PerfectChannel.App
{
    /// <summary>
    /// Provide a public Api
    /// </summary>
    public class Application
    {
        private Mower _currentMower;

        /// <summary>
        /// Set lawn boundries
        /// </summary>
        /// <param name="input"></param>
        public void InitLawn(string input)
        {
            LawnInitialiser.Init(input);
        }

        /// <summary>
        /// Set mower direction and position
        /// </summary>
        /// <param name="input"></param>
        public void InitMower(string input)
        {
            _currentMower = MowerFactory.Init(input);
        }

        /// <summary>
        /// Drive our mower will throw in mower not initialised
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public string RunCommand(string command)
        {
            if (_currentMower == null)
                throw new NullReferenceException("Please run InitMower() before running command");

            _currentMower.RunCommand(command);

            return _currentMower.ToString();
        }
    }
}