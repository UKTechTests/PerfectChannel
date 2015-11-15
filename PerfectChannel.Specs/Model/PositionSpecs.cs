using NUnit.Framework;
using PerfectChannel.App.Exceptions;
using PerfectChannel.App.Model;

namespace PerfectChannel.Specs.Model
{
    [TestFixture]
    public class PositionSpecs
    {
        private Position _position;

        [SetUp]
        public void OnBeforeEachTest()
        {
            Lawn.Initialise(5, 5);

            _position = new Position(0, 0);
        }

        [Test]
        public void ShouldThrowIfXOutOfRange()
        {
            Assert.Throws<OutOfBoundsException>(() => _position.TrySetX(6));
        }
        
        [Test]
        public void ShouldThrowIfYOutOfRange()
        {
            Assert.Throws<OutOfBoundsException>(() => _position.TrySetY(6));
        }
    }
}