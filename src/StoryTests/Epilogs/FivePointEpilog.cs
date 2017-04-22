using System;
using System.Threading.Tasks;

namespace StoryTests.Epilogs
{
    internal class FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> : IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>
    {
        private readonly TService1 _service1;
        private readonly TService2 _service2;
        private readonly TService3 _service3;
        private readonly TService4 _service4;
        private readonly TSubject _subject;
        private readonly TResult _result;

        public FivePointEpilog(TSubject subject, TService1 service1, TService2 service2, TService3 service3, TService4 service4, TResult result1)
        {
            _subject = subject;
            _service1 = service1;
            _service2 = service2;
            _result = result1;
            _service3 = service3;
            _service4 = service4;
        }

        public IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut> ThenCalling<TOut>(Func<TSubject, TResult, TOut> func)
        {
            return new FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>(_subject, _service1, _service2, _service3, _service4, func(_subject, _result));
        }

        public IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut> ThenCalling<TOut>(Func<TService1, TResult, TOut> func)
        {
            return new FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>(_subject, _service1, _service2, _service3, _service4, func(_service1, _result));
        }

        public IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut> ThenCalling<TOut>(Func<TService2, TResult, TOut> func)
        {
            return new FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>(_subject, _service1, _service2, _service3, _service4, func(_service2, _result));
        }

        public IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut> ThenCalling<TOut>(Func<TService3, TResult, TOut> func)
        {
            return new FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>(_subject, _service1, _service2, _service3, _service4, func(_service3, _result));
        }

        public IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut> ThenCalling<TOut>(Func<TService4, TResult, TOut> func)
        {
            return new FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>(_subject, _service1, _service2, _service3, _service4, func(_service4, _result));
        }

        public IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TResult> func)
        {
            func(_result);
            return new FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>(_subject, _service1, _service2, _service3, _service4, _result);
        }

        public IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TSubject, TResult> func)
        {
            func(_subject, _result);
            return this;
        }

        public IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TService1, TResult> func)
        {
            func(_service1, _result);
            return this;
        }

        public IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TService2, TResult> func)
        {
            func(_service2, _result);
            return this;
        }

        public IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TService3, TResult> func)
        {
            func(_service3, _result);
            return this;
        }

        public IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TService4, TResult> func)
        {
            func(_service4, _result);
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

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>> ThenCalling<TOut>(Func<TSubject, TResult, Task<TOut>> func)
        {
            return new FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>(_subject, _service1, _service2, _service3, _service4, await func(_subject, _result));
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>> ThenCalling<TOut>(Func<TService1, TResult, Task<TOut>> func)
        {
            return new FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>(_subject, _service1, _service2, _service3, _service4, await func(_service1, _result));
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>> ThenCalling<TOut>(Func<TService2, TResult, Task<TOut>> func)
        {
            return new FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>(_subject, _service1, _service2, _service3, _service4, await func(_service2, _result));
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>> ThenCalling<TOut>(Func<TService3, TResult, Task<TOut>> func)
        {
            return new FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>(_subject, _service1, _service2, _service3, _service4, await func(_service3, _result));
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>> ThenCalling<TOut>(Func<TService4, TResult, Task<TOut>> func)
        {
            return new FivePointEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>(_subject, _service1, _service2, _service3, _service4, await func(_service4, _result));
        }

        public Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TResult, Task> func)
        {
            throw new NotImplementedException();
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TSubject, TResult, Task> func)
        {
            await func(_subject, _result);
            return this;
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TService1, TResult, Task> func)
        {
            await func(_service1, _result);
            return this;
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TService2, TResult, Task> func)
        {
            await func(_service2, _result);
            return this;
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TService3, TResult, Task> func)
        {
            await func(_service3, _result);
            return this;
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TService4, TResult, Task> func)
        {
            await func(_service4, _result);
            return this;
        }

        public Task<TOut> ThenReturn<TOut>(Func<TResult, Task<TOut>> func)
        {
            return func(_result);
        }
    }
}