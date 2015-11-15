using NUnit.Framework;
using PerfectChannel.App;
using PerfectChannel.App.Exceptions;

namespace PerfectChannel.Specs
{
    [TestFixture]
    public class MowerFactorySpecs
    {
        [Test]
        public void ShouldCreateAMower()
        {
            var mower = MowerFactory.Init("1 2 N");

            Assert.That(mower.Position.X, Is.EqualTo(1));
            Assert.That(mower.Position.Y, Is.EqualTo(2));
            Assert.That(mower.Direction, Is.EqualTo(0));
        }

        [Test]
        public void ShouldThrowIfCantParseCoord()
        {
            Assert.Throws<InvalidInputException>(() => MowerFactory.Init("1 x N"));
        }
    }
}