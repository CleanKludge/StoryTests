using Moq;
using NUnit.Framework;

namespace StoryTests.Integration.Tests.GivenAOnePointStory.With
{
    [TestFixture]
    public class WhenCalling
    {
        private Mock<ITestClient> _subject;
        private int _result;

        [OneTimeSetUp]
        public void SetUp()
        {
            _subject = new Mock<ITestClient>(MockBehavior.Loose);
            _subject.Setup(x => x.WhenCalling()).Returns(10);

            _result = Given.ANewStoryAbout(_subject.Object)
                .With(x => x.With())
                .WhenCalling(x => x.WhenCalling())
                .ThenReturnTheResult();
        }

        [Test]
        public void ThenWithIsCalledOnce()
        {
            _subject.Verify(x => x.With(), Times.Once);
        }

        [Test]
        public void ThenAndIsNeverCalled()
        {
            _subject.Verify(x => x.And(), Times.Never);
        }

        [Test]
        public void ThenWhenCallingIsCalledOnce()
        {
            _subject.Verify(x => x.WhenCalling(), Times.Once);
        }

        [Test]
        public void ThenTheResultIsReturned()
        {
            Assert.That(_result, Is.EqualTo(10));
        }
    }
}