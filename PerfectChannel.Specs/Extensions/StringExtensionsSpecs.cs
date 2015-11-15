using NUnit.Framework;
using PerfectChannel.App.Exceptions;
using PerfectChannel.App.Extensions;

namespace PerfectChannel.Specs.Extensions
{
    [TestFixture]
    public class StringExtensionsSpecs
    {
        [Test]
        public void ShouldThrowIfIncorrectLength()
        {
            Assert.Throws<InvalidInputException>(() => "1 2".AssertedSplitOnSpace(3));
        }

        [Test]
        public void ShouldReturnSplitBits()
        {
            Assert.That("1 2".AssertedSplitOnSpace(2).Length, Is.EqualTo(2));
            Assert.That("1 2".AssertedSplitOnSpace(2), Is.EqualTo(new[] {"1", "2"}));
        }

        [Test]
        public void ShouldConvertCompassToInt()
        {
            Assert.That("N".ToDirection(), Is.EqualTo(0));
            Assert.That("e".ToDirection(), Is.EqualTo(1));
            Assert.That("S".ToDirection(), Is.EqualTo(2));
            Assert.That("w".ToDirection(), Is.EqualTo(3));

            Assert.Throws<InvalidInputException>(()=> "".ToDirection());
        }
    }
}