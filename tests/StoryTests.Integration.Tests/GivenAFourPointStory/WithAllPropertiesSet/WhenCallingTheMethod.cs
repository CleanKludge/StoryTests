﻿using System.Threading.Tasks;
using NUnit.Framework;
using StoryTests.Epilogs;

namespace StoryTests.Integration.Tests.GivenAFourPointStory.WithAllPropertiesSet
{
    [TestFixture]
    public class WhenCallingTheMethod
    {
        private Result _result;

        public class Client
        {
            public Task<Result> Method(Item1 item1, Item2 item2, Item3 item3)
            {
                return Task.FromResult(new Result { Property1 = item1.Property, Property2 = item2.Property, Property3 = item3.Property });
            }
        }

        public class Result
        {
            public int Property1 { get; set; }
            public int Property2 { get; set; }
            public int Property3 { get; set; }

            public Task AddFive()
            {
                Property1 += 5;
                Property2 += 5;
                Property3 += 5;
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

        public class Item3
        {
            public int Property { get; set; }
        }

        [OneTimeSetUp]
        public async Task SetUp()
        {
            _result = await Given.ANewStoryAbout(new Client(), new Item1(), new Item2(), new Item3())
                .With((Item1 x) => x.Property = 1)
                .With((Item2 x) => x.Property = 2)
                .With((Item3 x) => x.Property = 3)
                .WhenCalling((c, i1, i2, i3) => c.Method(i1, i2, i3))
                .Then((Client c, Result r) => r.AddFive())
                .ThenReturnTheResult();
        }

        [Test]
        public void ThenTheStoryIsProcesssedCorrectly()
        {
            Assert.That(_result.Property1, Is.EqualTo(6));
            Assert.That(_result.Property2, Is.EqualTo(7));
            Assert.That(_result.Property3, Is.EqualTo(8));
        }
    }
}