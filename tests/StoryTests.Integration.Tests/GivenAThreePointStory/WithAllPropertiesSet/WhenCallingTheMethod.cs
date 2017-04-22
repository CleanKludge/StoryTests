using System.Threading.Tasks;
using NUnit.Framework;
using StoryTests.Epilogs;

namespace StoryTests.Integration.Tests.GivenAThreePointStory.WithAllPropertiesSet
{
    [TestFixture]
    public class WhenCallingTheMethod
    {
        private Result _result;

        public class Client
        {
            public Task<Result> Method(Item1 item1, Item2 item2)
            {
                return Task.FromResult(new Result { Property1 = item1.Property, Property2 = item2.Property });
            }
        }

        public class Result
        {
            public int Property1 { get; set; }
            public int Property2 { get; set; }

            public Task AddFive()
            {
                Property1 += 5;
                Property2 += 5;
                return Task.CompletedTask;
            }
        }

        public class Item1
        {
            public int Property { get; set; }
        }

        public class Item2
        {
            public int Property { get; set; }
        }

        [OneTimeSetUp]
        public async Task SetUp()
        {
            _result = await Given.ANewStoryAbout(new Client(), new Item1(), new Item2())
                .With((Item1 x) => x.Property = 1)
                .With((Item2 x) => x.Property = 2)
                .WhenCalling((c, i1, i2) => c.Method(i1, i2))
                .Then((Client c, Result r) => r.AddFive())
                .ThenReturnTheResult();
        }

        [Test]
        public void ThenTheStoryIsProcesssedCorrectly()
        {
            Assert.That(_result.Property1, Is.EqualTo(6));
            Assert.That(_result.Property2, Is.EqualTo(7));
        }
    }
}