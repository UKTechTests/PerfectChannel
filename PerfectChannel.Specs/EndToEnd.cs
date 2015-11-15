using System;
using NUnit.Framework;
using PerfectChannel.App;

namespace PerfectChannel.Specs
{
    [TestFixture]
    public class EndToEnd
    {
        private Application _app;

        [SetUp]
        public void OnBeforeEachTest()
        {
            _app = new Application();
        }

        [Test]
        public void ShouldRunEndToEnd1()
        {
            _app.InitLawn("5 5");
            _app.InitMower("1 2 N");

            var result = _app.RunCommand("LMLMLMLMM");

            Assert.That(result, Is.EqualTo("1 3 N"));
        }

        [Test]
        public void ShouldRunEndToEnd2()
        {
            _app.InitLawn("5 5");
            _app.InitMower("3 3 E");

            var result = _app.RunCommand("MMRMMRMRRM");

            Assert.That(result, Is.EqualTo("5 1 E"));
        }

        [Test]
        public void ShouldThrowIfMowerNotInitialised()
        {
            Assert.Throws<NullReferenceException>(() => _app.RunCommand("M"));
        }
    }
}