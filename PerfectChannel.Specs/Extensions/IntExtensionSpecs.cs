using NUnit.Framework;
using PerfectChannel.App.Exceptions;
using PerfectChannel.App.Extensions;

namespace PerfectChannel.Specs.Extensions
{
    [TestFixture]
    public class IntExtensionSpecs
    {
        [Test]
        public void ShouldConvertToCompass()
        {
            Assert.That(0.ToCompass(), Is.EqualTo("N"));
            Assert.That(1.ToCompass(), Is.EqualTo("E"));
            Assert.That(2.ToCompass(), Is.EqualTo("S"));
            Assert.That(3.ToCompass(), Is.EqualTo("W"));

            Assert.Throws<InvalidInputException>(() => (-1).ToCompass());
            Assert.Throws<InvalidInputException>(() => 4.ToCompass());
        }
    }
}