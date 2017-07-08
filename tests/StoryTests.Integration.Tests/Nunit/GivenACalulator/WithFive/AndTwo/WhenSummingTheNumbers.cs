using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace StoryTests.Integration.Tests.Nunit.GivenACalulator.WithFive.AndTwo
{
    [TestFixture]
    public class WhenSummingTheNumbers
    {
        private Story<CalculatorContext, CalculateResult> _story;

        [OneTimeSetUp]
        public async Task SetUp()
        {
            _story = await Given
                .A<CalculatorContext>()
                .With(Five)
                .And(Two)
                .When(SummingTheNumbers);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _story.FinallyDisposeOfContext();
        }

        [Test]
        public void ThenTheResultShouldBeFivePlusTwo()
        {
            _story.Then(result => result.Value.ShouldBe(7));
        }

        private static Task<CalculateResult> SummingTheNumbers(CalculatorContext context)
        {
            return Task.FromResult(context.Client.Sum());
        }

        private static Task Five(CalculatorContext context)
        {
            context.Client.Add(5);
            return Task.CompletedTask;
        }

        private static Task Two(CalculatorContext context)
        {
            context.Client.Add(2);
            return Task.CompletedTask;
        }
    }
}