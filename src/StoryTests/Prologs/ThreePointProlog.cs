using System;
using System.Threading.Tasks;
using StoryTests.Epilogs;

namespace StoryTests.Prologs
{
    public class ThreePointProlog<TSubject, TService1, TService2> : IStoryProlog<TSubject, TService1, TService2>
    {
        private readonly TService1 _service1;
        private readonly TService2 _service2;
        private readonly TSubject _subject;

        public ThreePointProlog(TSubject subject, TService1 service1, TService2 service2)
        {
            _subject = subject;
            _service1 = service1;
            _service2 = service2;
        }

        public IStoryProlog<TSubject, TService1, TService2> With(Action<TSubject> action)
        {
            action(_subject);
            return this;
        }

        public async Task<IStoryProlog<TSubject, TService1, TService2>> With(Func<TSubject, Task> action)
        {
            await action(_subject);
            return this;
        }

        public IStoryProlog<TSubject, TService1, TService2> With(Action<TService1> action)
        {
            action(_service1);
            return this;
        }

        public async Task<IStoryProlog<TSubject, TService1, TService2>> With(Func<TService1, Task> action)
        {
            await action(_service1);
            return this;
        }


        public IStoryProlog<TSubject, TService1, TService2> With(Action<TService2> action)
        {
            action(_service2);
            return this;
        }

        public async Task<IStoryProlog<TSubject, TService1, TService2>> With(Func<TService2, Task> action)
        {
            await action(_service2);
            return this;
        }

        public IStoryProlog<TSubject, TService1, TService2> And(Action<TSubject> action)
        {
            action(_subject);
            return this;
        }

        public async Task<IStoryProlog<TSubject, TService1, TService2>> And(Func<TSubject, Task> action)
        {
            await action(_subject);
            return this;
        }

        public IStoryProlog<TSubject, TService1, TService2> And(Action<TService1> action)
        {
            action(_service1);
            return this;
        }

        public async Task<IStoryProlog<TSubject, TService1, TService2>> And(Func<TService1, Task> action)
        {
            await action(_service1);
            return this;
        }

        public IStoryProlog<TSubject, TService1, TService2> And(Action<TService2> action)
        {
            action(_service2);
            return this;
        }

        public async Task<IStoryProlog<TSubject, TService1, TService2>> And(Func<TService2, Task> action)
        {
            await action(_service2);
            return this;
        }

        public IStoryEpilog<TSubject, TService1, TService2, TResult> When<TResult>(Func<TSubject, TResult> action)
        {
            return new ThreePointEpilog<TSubject, TService1, TService2, TResult>(_subject, _service1, _service2, action(_subject));
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TResult>> When<TResult>(Func<TSubject, Task<TResult>> action)
        {
            return new ThreePointEpilog<TSubject, TService1, TService2, TResult>(_subject, _service1, _service2, await action(_subject));
        }

        public IStoryEpilog<TSubject, TService1, TService2, TResult> WhenCalling<TResult>(Func<TSubject, TResult> action)
        {
            return new ThreePointEpilog<TSubject, TService1, TService2, TResult>(_subject, _service1, _service2, action(_subject));
        }

        public IStoryEpilog<TSubject, TService1, TService2, TResult> WhenCalling<TResult>(Func<TSubject, TService1, TService2, TResult> action)
        {
            return new ThreePointEpilog<TSubject, TService1, TService2, TResult>(_subject, _service1, _service2, action(_subject, _service1, _service2));
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TResult>> WhenCalling<TResult>(Func<TSubject, Task<TResult>> action)
        {
            return new ThreePointEpilog<TSubject, TService1, TService2, TResult>(_subject, _service1, _service2, await action(_subject));
        }

        public async Task<IStoryEpilog<TSubject, TService1, TService2, TResult>> WhenCalling<TResult>(Func<TSubject, TService1, TService2, Task<TResult>> action)
        {
            return new ThreePointEpilog<TSubject, TService1, TService2, TResult>(_subject, _service1, _service2, await action(_subject, _service1, _service2));
        }
    }
}