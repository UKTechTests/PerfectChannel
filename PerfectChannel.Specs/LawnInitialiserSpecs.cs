using NUnit.Framework;
using PerfectChannel.App;
using PerfectChannel.App.Exceptions;
using PerfectChannel.App.Model;

namespace PerfectChannel.Specs
{
    [TestFixture]
    public class LawnInitialiserSpecs
    {
        [Test]
        public void ShouldThrowIfInvalidInput()
        {
            Assert.Throws<InvalidInputException>(() => LawnInitialiser.Init("5"));
            Assert.Throws<InvalidInputException>(() => LawnInitialiser.Init("x x"));
        }

        [Test]
        public void ShouldInitialiseTheLawnAsRectangle()
        {
            LawnInitialiser.Init("5 15");

            Assert.That(Lawn.Height, Is.EqualTo(5));
            Assert.That(Lawn.Width, Is.EqualTo(15));
        }
    }
}
