using NUnit.Framework;
using PerfectChannel.App.Model;

namespace PerfectChannel.Specs.Model
{
    [TestFixture]
    public class PositionValidatorSpecs
    {
        private PositionValidator _validator;

        [SetUp]
        public void OnSetup()
        {
            _validator = new PositionValidator(5, 5);
        }

        [Test]
        public void ShouldValidateXOutOfRange()
        {            
            Assert.That(_validator.XInRange(6), Is.False);
            Assert.That(_validator.XInRange(-1), Is.False);
        }

        [Test]
        public void ShouldValidateXInRange()
        {
            Assert.That(_validator.XInRange(5), Is.True);
            Assert.That(_validator.XInRange(0), Is.True);
        }

        [Test]
        public void ShouldValidateYOutOfRange()
        {
            Assert.That(_validator.YInRange(6), Is.False);
            Assert.That(_validator.YInRange(-1), Is.False);
        }

        [Test]
        public void ShouldValidateYInRange()
        {
            Assert.That(_validator.YInRange(5), Is.True);
            Assert.That(_validator.YInRange(0), Is.True);
        }
    }
}