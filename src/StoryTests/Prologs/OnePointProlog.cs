using System;
using System.Threading.Tasks;
using StoryTests.Epilogs;

namespace StoryTests.Prologs
{
    public class OnePointProlog<TSubject> : IStoryProlog<TSubject>
    {
        private readonly TSubject _subject;

        public OnePointProlog(TSubject subject)
        {
            _subject = subject;
        }

        public IStoryProlog<TSubject> With(Action<TSubject> action)
        {
            action(_subject);
            return this;
        }

        public async Task<IStoryProlog<TSubject>> With(Func<TSubject, Task> action)
        {
            await action(_subject);
            return this;
        }

        public IStoryProlog<TSubject> And(Action<TSubject> action)
        {
            action(_subject);
            return this;
        }

        public async Task<IStoryProlog<TSubject>> And(Func<TSubject, Task> action)
        {
            await action(_subject);
            return this;
        }

        public IStoryEpilog<TSubject, TResult> When<TResult>(Func<TSubject, TResult> action)
        {
            return new OnePointEpilog<TSubject, TResult>(_subject, action(_subject));
        }

        public async Task<IStoryEpilog<TSubject, TResult>> When<TResult>(Func<TSubject, Task<TResult>> action)
        {
            return new OnePointEpilog<TSubject, TResult>(_subject, await action(_subject));
        }

        public IStoryEpilog<TSubject, TResult> WhenCalling<TResult>(Func<TSubject, TResult> action)
        {
            return new OnePointEpilog<TSubject, TResult>(_subject, action(_subject));
        }

        public async Task<IStoryEpilog<TSubject, TResult>> WhenCalling<TResult>(Func<TSubject, Task<TResult>> action)
        {
            return new OnePointEpilog<TSubject, TResult>(_subject, await action(_subject));
        }
    }
}