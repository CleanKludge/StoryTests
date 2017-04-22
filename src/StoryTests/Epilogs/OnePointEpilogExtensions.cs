using System;
using System.Threading.Tasks;

namespace StoryTests.Epilogs
{
    public static class OnePointEpilogExtensions
    {
        public static async Task<IStoryEpilog<TSubject, TResult>> Then<TSubject, TResult>(this Task<IStoryEpilog<TSubject, TResult>> self, Func<TSubject, TResult, Task> func)
        {
            var epilog = await self;
            return await epilog.Then(func);
        }

        public static async Task<IStoryEpilog<TSubject, TResult>> Then<TSubject, TResult>(this Task<IStoryEpilog<TSubject, TResult>> self, Func<TResult, Task> func)
        {
            var epilog = await self;
            return await epilog.Then(func);
        }

        public static async Task<IStoryEpilog<TSubject, TOut>> ThenCalling<TSubject, TResult, TOut>(this Task<IStoryEpilog<TSubject, TResult>> self, Func<TSubject, TResult, Task<TOut>> func)
        {
            var epilog = await self;
            return await epilog.ThenCalling(func);
        }

        public static async Task<IStoryEpilog<TSubject, TResult>> Then<TSubject, TResult>(this Task<IStoryEpilog<TSubject, TResult>> self, Action<TResult> action)
        {
            var epilog = await self;
            return epilog.Then(action);
        }

        public static async Task<TOut> ThenReturn<TSubject, TResult, TOut>(this Task<IStoryEpilog<TSubject, TResult>> self, Func<TResult, Task<TOut>> func)
        {
            var epilog = await self;
            return await epilog.ThenReturn(func);
        }

        public static async Task<TResult> ThenReturnTheResult<TSubject, TResult>(this Task<IStoryEpilog<TSubject, TResult>> self)
        {
            var epilog = await self;
            return epilog.ThenReturnTheResult();
        }
    }
}