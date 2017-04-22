using System;
using System.Threading.Tasks;

namespace StoryTests.Epilogs
{
    public static class FourPointEpilogExtensions
    {
        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> And<TSubject, TService1, TService2, TService3, TResult, TOut>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TSubject, TResult, Task<TOut>> func)
        {
            var epilog = await self;
            return await epilog.ThenCalling(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> And<TSubject, TService1, TService2, TService3, TResult, TOut>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TService1, TResult, Task<TOut>> func)
        {
            var epilog = await self;
            return await epilog.ThenCalling(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> And<TSubject, TService1, TService2, TService3, TResult, TOut>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TService2, TResult, Task<TOut>> func)
        {
            var epilog = await self;
            return await epilog.ThenCalling(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> And<TSubject, TService1, TService2, TService3, TResult, TOut>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TService3, TResult, Task<TOut>> func)
        {
            var epilog = await self;
            return await epilog.ThenCalling(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> Then<TSubject, TService1, TService2, TService3, TResult>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TSubject, TResult, Task> func)
        {
            var epilog = await self;
            return await epilog.Then(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> Then<TSubject, TService1, TService2, TService3, TResult>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TService1, TResult, Task> func)
        {
            var epilog = await self;
            return await epilog.Then(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> Then<TSubject, TService1, TService2, TService3, TResult>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TService2, TResult, Task> func)
        {
            var epilog = await self;
            return await epilog.Then(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> Then<TSubject, TService1, TService2, TService3, TResult>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TService3, TResult, Task> func)
        {
            var epilog = await self;
            return await epilog.Then(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> Then<TSubject, TService1, TService2, TService3, TResult>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TResult, Task> func)
        {
            var epilog = await self;
            return await epilog.Then(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> Then<TSubject, TService1, TService2, TService3, TResult>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Action<TResult> func)
        {
            var epilog = await self;
            return epilog.Then(func);
        }

        public static async Task<TOut> ThenReturn<TSubject, TService1, TService2, TService3, TResult, TOut>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TResult, Task<TOut>> func)
        {
            var epilog = await self;
            return await epilog.ThenReturn(func);
        }

        public static async Task<TResult> ThenReturnTheResult<TSubject, TService1, TService2, TService3, TResult>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self)
        {
            var epilog = await self;
            return epilog.ThenReturnTheResult();
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> ThenCalling<TSubject, TResult, TOut, TService1, TService2, TService3>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TSubject, TResult, Task<TOut>> func)
        {
            var result = await self;
            return await result.ThenCalling(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> ThenCalling<TService1, TResult, TOut, TSubject, TService2, TService3>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TService1, TResult, Task<TOut>> func)
        {
            var result = await self;
            return await result.ThenCalling(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> ThenCalling<TService2, TResult, TOut, TSubject, TService1, TService3>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TService2, TResult, Task<TOut>> func)
        {
            var result = await self;
            return await result.ThenCalling(func);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> ThenCalling<TService3, TResult, TOut, TSubject, TService1, TService2>(this Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> self, Func<TService3, TResult, Task<TOut>> func)
        {
            var result = await self;
            return await result.ThenCalling(func);
        }
    }
}