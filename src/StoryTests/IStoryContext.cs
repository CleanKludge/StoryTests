using System;
using System.Threading.Tasks;

namespace StoryTests
{
    public interface IStoryContext : IDisposable
    {
        Task Initialise();
    }
}