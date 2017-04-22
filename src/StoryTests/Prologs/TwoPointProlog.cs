using System;
using System.Threading.Tasks;
using StoryTests.Epilogs;

namespace StoryTests.Prologs
{
    public class TwoPointProlog<TSubject, TService1> : IStoryProlog<TSubject, TService1>
    {
        private readonly TService1 _service1;
        private readonly TSubject _subject;

        public TwoPointProlog(TSubject subject, TService1 service1)
        {
            _subject = subject;
            _service1 = service1;
        }

        public IStoryProlog<TSubject, TService1> With(Action<TSubject> action)
        {
            action(_subject);
            return this;
        }

        public async Task<IStoryProlog<TSubject, TService1>> With(Func<TSubject, Task> action)
        {
            await action(_subject);
            return this;
        }

        public IStoryProlog<TSubject, TService1> With(Action<TService1> action)
        {
            action(_service1);
            return this;
        }

        public async Task<IStoryProlog<TSubject, TService1>> With(Func<TService1, Task> action)
        {
            await action(_service1);
            return this;
        }

        public IStoryProlog<TSubject, TService1> And(Action<TSubject> action)
        {
            action(_subject);
            return this;
        }

        public async Task<IStoryProlog<TSubject, TService1>> And(Func<TSubject, Task> action)
        {
            await action(_subject);
            return this;
        }

        public IStoryProlog<TSubject, TService1> And(Action<TService1> action)
        {
            action(_service1);
            return this;
        }

        public async Task<IStoryProlog<TSubject, TService1>> And(Func<TService1, Task> action)
        {
            await action(_service1);
            return this;
        }

        public IStoryEpilog<TSubject, TService1, TResult> When<TResult>(Func<TSubject, TResult> action)
        {
            return new TwoPointEpilog<TSubject, TService1, TResult>(_subject, _service1, action(_subject));
        }

        public async Task<IStoryEpilog<TSubject, TService1, TResult>> When<TResult>(Func<TSubject, Task<TResult>> action)
        {
            return new TwoPointEpilog<TSubject, TService1, TResult>(_subject, _service1, await action(_subject));
        }

        public IStoryEpilog<TSubject, TService1, TResult> WhenCalling<TResult>(Func<TSubject, TResult> action)
        {
            return new TwoPointEpilog<TSubject, TService1, TResult>(_subject, _service1, action(_subject));
        }

        public IStoryEpilog<TSubject, TService1, TResult> WhenCalling<TResult>(Func<TSubject, TService1, TResult> action)
        {
            return new TwoPointEpilog<TSubject, TService1, TResult>(_subject, _service1, action(_subject, _service1));
        }

        public async Task<IStoryEpilog<TSubject, TService1, TResult>> WhenCalling<TResult>(Func<TSubject, Task<TResult>> action)
        {
            return new TwoPointEpilog<TSubject, TService1, TResult>(_subject, _service1, await action(_subject));
        }

        public async Task<IStoryEpilog<TSubject, TService1, TResult>> WhenCalling<TResult>(Func<TSubject, TService1, Task<TResult>> action)
        {
            return new TwoPointEpilog<TSubject, TService1, TResult>(_subject, _service1, await action(_subject, _service1));
        }
    }
}