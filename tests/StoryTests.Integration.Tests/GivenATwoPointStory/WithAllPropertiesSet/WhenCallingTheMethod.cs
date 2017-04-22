using System.Threading.Tasks;
using NUnit.Framework;
using StoryTests.Epilogs;

namespace StoryTests.Integration.Tests.GivenATwoPointStory.WithAllPropertiesSet
{
    [TestFixture]
    public class WhenCallingTheMethod
    {
        private Result _result;

        public class Client
        {
            public Task<Result> Method(Item1 item1)
            {
                return Task.FromResult(new Result { Property1 = item1.Property });
            }
        }

        public class Result
        {
            public int Property1 { get; set; }

            public Task AddFive()
            {
                Property1 += 5;
                return Task.CompletedTask;
            }
        }

        public class Item1
        {
            public int Property { get; set; }
        }

        [OneTimeSetUp]
        public async Task SetUp()
        {
            _result = await Given.ANewStoryAbout(new Client(), new Item1())
                .With(x => x.Property = 1)
                .WhenCalling((c, i1) => c.Method(i1))
                .Then((Client c, Result r) => r.AddFive())
                .ThenReturnTheResult();
        }

        [Test]
        public void ThenTheStoryIsProcesssedCorrectly()
        {
            Assert.That(_result.Property1, Is.EqualTo(6));
        }
    }
}