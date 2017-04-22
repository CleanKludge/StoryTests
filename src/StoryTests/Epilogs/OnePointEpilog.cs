using System;
using System.Threading.Tasks;

namespace StoryTests.Epilogs
{
    internal class OnePointEpilog<TSubject, TResult> : IStoryEpilog<TSubject, TResult>
    {
        private readonly TResult _result;
        private readonly TSubject _subject;

        public OnePointEpilog(TSubject subject, TResult result1)
        {
            _subject = subject;
            _result = result1;
        }

        public IStoryEpilog<TSubject, TOut> ThenCalling<TOut>(Func<TSubject, TResult, TOut> func)
        {
            return new OnePointEpilog<TSubject, TOut>(_subject, func(_subject, _result));
        }

        public IStoryEpilog<TSubject, TOut> And<TOut>(Func<TResult, TOut> func)
        {
            return new OnePointEpilog<TSubject, TOut>(_subject, func(_result));
        }

        public IStoryEpilog<TSubject, TResult> Then(Action<TSubject, TResult> func)
        {
            func(_subject, _result);
            return this;
        }

        public IStoryEpilog<TSubject, TResult> Then(Action<TResult> func)
        {
            func(_result);
            return new OnePointEpilog<TSubject, TResult>(_subject, _result);
        }

        public TOut ThenReturn<TOut>(Func<TResult, TOut> func)
        {
            return func(_result);
        }

        public TResult ThenReturnTheResult()
        {
            return _result;
        }

        public async Task<IStoryEpilog<TSubject, TOut>> ThenCalling<TOut>(Func<TSubject, TResult, Task<TOut>> func)
        {
            return new OnePointEpilog<TSubject, TOut>(_subject, await func(_subject, _result));
        }

        public async Task<IStoryEpilog<TSubject, TResult>> Then(Func<TSubject, TResult, Task> func)
        {
            await func(_subject, _result);
            return this;
        }

        public async Task<IStoryEpilog<TSubject, TResult>> Then(Func<TResult, Task> func)
        {
            await func(_result);
            return this;
        }

        public Task<TOut> ThenReturn<TOut>(Func<TResult, Task<TOut>> func)
        {
            return func(_result);
        }
    }
}