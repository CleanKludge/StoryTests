using System;
using System.Threading.Tasks;

namespace StoryTests
{
    public interface IContext : IDisposable
    {
        Task Initialise();
    }
}