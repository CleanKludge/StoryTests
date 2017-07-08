using System.Threading.Tasks;

namespace StoryTests.Integration.Tests
{
    public class CalculatorContext : IStoryContext
    {
        public ICalculator Client { get; set; }

        public Task Initialise()
        {
            return Task.CompletedTask;
        }

        public void Dispose()
        {
        }
    }
}