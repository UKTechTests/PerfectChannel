using NUnit.Framework;
using PerfectChannel.App.Extensions;
using PerfectChannel.App.Model;

namespace PerfectChannel.Specs.Extensions
{
    [TestFixture]
    public class MowerExtensionSpecs
    {
        [TestFixtureSetUp]
        public void OnSetup()
        {
            Lawn.Initialise(10, 10);
        }

        [Test]
        public void ShouldMoveRight()
        {
            var mower = new Mower(0, 0, 0);

            mower.MoveRight();
            Assert.That(mower.Direction, Is.EqualTo(1));
            mower.MoveRight();
            Assert.That(mower.Direction, Is.EqualTo(2));
            mower.MoveRight();
            Assert.That(mower.Direction, Is.EqualTo(3));
            mower.MoveRight();
            Assert.That(mower.Direction, Is.EqualTo(0));
        }

        [Test]
        public void ShouldMoveLeft()
        {
            var mower = new Mower(0, 0, 0);

            mower.MoveLeft();
            Assert.That(mower.Direction, Is.EqualTo(3));
            mower.MoveLeft();
            Assert.That(mower.Direction, Is.EqualTo(2));
            mower.MoveLeft();
            Assert.That(mower.Direction, Is.EqualTo(1));
            mower.MoveLeft();
            Assert.That(mower.Direction, Is.EqualTo(0));
        }

        [Test]
        public void ShouldMoveNorth()
        {
            var mower = new Mower(0, 0, 0);
            mower.MoveForward();

            Assert.That(mower.Position.Y, Is.EqualTo(1));
            Assert.That(mower.Position.X, Is.EqualTo(0));
        }

        [Test]
        public void ShouldMoveEast()
        {
            var mower = new Mower(0, 0, 0);
            mower.MoveRight();
            mower.MoveForward();

            Assert.That(mower.Position.Y, Is.EqualTo(0));
            Assert.That(mower.Position.X, Is.EqualTo(1));
        }

        [Test]
        public void ShouldMoveSouth()
        {
            var mower = new Mower(0, 1, 0);
            mower.MoveRight();
            mower.MoveRight();
            mower.MoveForward();

            Assert.That(mower.Position.Y, Is.EqualTo(0));
            Assert.That(mower.Position.X, Is.EqualTo(0));
        }

        [Test]
        public void ShouldMoveWest()
        {
            var mower = new Mower(1, 1, 0);
            mower.MoveRight();
            mower.MoveRight();
            mower.MoveRight();
            mower.MoveForward();

            Assert.That(mower.Position.Y, Is.EqualTo(1));
            Assert.That(mower.Position.X, Is.EqualTo(0));
        }

        [Test]
        public void ShouldMoveLeftOffCommand()
        {
            var mower = new Mower(0, 0, 0);
            mower.RunCommand("LL");

            Assert.That(mower.Direction, Is.EqualTo(2));
        }

        [Test]
        public void ShouldMoveRightOffCommand()
        {
            var mower = new Mower(0, 0, 0);
            mower.RunCommand("RRR");

            Assert.That(mower.Direction, Is.EqualTo(3));
        }

        [Test]
        public void ShouldMoveForwardOffCommand()
        {
            var mower = new Mower(0, 0, 0);
            mower.RunCommand("MM");

            Assert.That(mower.Position.Y, Is.EqualTo(2));
        }

        [Test]
        public void ShouldRunFullCommand()
        {
            var mower = new Mower(1, 2, 0);
            mower.RunCommand("LMLMLMLMM");

            Assert.That(mower.Position.X, Is.EqualTo(1));
            Assert.That(mower.Position.Y, Is.EqualTo(3));
            Assert.That(mower.Direction, Is.EqualTo(0));
        }

        [Test]
        public void ShouldRunFullCommand1()
        {
            var mower = new Mower(3, 3, 1);
            mower.RunCommand("MMRMMRMRRM");

            Assert.That(mower.Position.X, Is.EqualTo(5));
            Assert.That(mower.Position.Y, Is.EqualTo(1));
            Assert.That(mower.Direction, Is.EqualTo(1));
        }
    }
}