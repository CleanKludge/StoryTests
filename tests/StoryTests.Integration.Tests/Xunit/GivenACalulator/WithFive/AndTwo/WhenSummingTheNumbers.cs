using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace StoryTests.Integration.Tests.Xunit.GivenACalulator.WithFive.AndTwo
{
    public class WhenSummingTheNumbers
    {
        [Fact]
        public async Task ThenTheResultShouldBeFivePlusTwo()
        {
            await Given
                .A<CalculatorContext>()
                .With(Five)
                .And(Two)
                .When(SummingTheNumbers)
                .Then(result => { result.Value.ShouldBe(7); })
                .FinallyDisposeOfContext();
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