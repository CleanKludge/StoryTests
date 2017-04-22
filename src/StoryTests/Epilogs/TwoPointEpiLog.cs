using System;
using System.Threading.Tasks;

namespace StoryTests.Epilogs
{
    internal class TwoPointEpilog<TSubject, TService1, TResult> : IStoryEpilog<TSubject, TService1, TResult>
    {
        private readonly TService1 _service1;
        private readonly TSubject _subject;
        private readonly TResult _result;

        public TwoPointEpilog(TSubject subject, TService1 service1, TResult result1)
        {
            _subject = subject;
            _service1 = service1;
            _result = result1;
        }

        public IStoryEpilog<TSubject, TService1, TOut> ThenCalling<TOut>(Func<TSubject, TResult, TOut> func)
        {
            return new TwoPointEpilog<TSubject, TService1, TOut>(_subject, _service1, func(_subject, _result));
        }

        public IStoryEpilog<TSubject, TService1, TOut> ThenCalling<TOut>(Func<TService1, TResult, TOut> func)
        {
            return new TwoPointEpilog<TSubject, TService1, TOut>(_subject, _service1, func(_service1, _result));
        }

        public IStoryEpilog<TSubject, TService1, TResult> Then(Action<TService1, TResult> func)
        {
            func(_service1, _result);
            return this;
        }

        public IStoryEpilog<TSubject, TService1, TResult> Then(Action<TSubject, TResult> func)
        {
            func(_subject, _result);
            return this;
        }

        public TOut ThenReturn<TOut>(Func<TResult, TOut> func)
        {
            return func(_result);
        }

        public TResult ThenReturnTheResult()
        {
            return _result;
        }

        public async Task<IStoryEpilog<TSubject, TService1, TOut>> ThenCalling<TOut>(Func<TSubject, TResult, Task<TOut>> func)
        {
            return new TwoPointEpilog<TSubject, TService1, TOut>(_subject, _service1, await func(_subject, _result));
        }

        public async Task<IStoryEpilog<TSubject, TService1, TOut>> ThenCalling<TOut>(Func<TService1, TResult, Task<TOut>> func)
        {
            return new TwoPointEpilog<TSubject, TService1, TOut>(_subject, _service1, await func(_service1, _result));
        }

        public IStoryEpilog<TSubject, TService1, TResult> Then(Action<TResult> func)
        {
            func(_result);
            return new TwoPointEpilog<TSubject, TService1, TResult>(_subject, _service1, _result);
        }

        public async Task<IStoryEpilog<TSubject, TService1, TResult>> Then(Func<TSubject, TResult, Task> func)
        {
            await func(_subject, _result);
            return this;
        }

        public async Task<IStoryEpilog<TSubject, TService1, TResult>> Then(Func<TService1, TResult, Task> func)
        {
            await func(_service1, _result);
            return this;
        }

        public async Task<IStoryEpilog<TSubject, TService1, TResult>> Then(Func<TResult, Task> func)
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