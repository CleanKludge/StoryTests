using System;
using System.Threading.Tasks;
using StoryTests.Epilogs;

namespace StoryTests.Prologs
{
    public static class OnePointPrologExtensions
    {
        public static async Task<IStoryProlog<TSubject>> With<TSubject>(this Task<IStoryProlog<TSubject>> self, Func<TSubject, Task> action)
        {
            var prolog = await self;
            return await prolog.With(action);
        }

        public static async Task<IStoryProlog<TSubject>> And<TSubject>(this Task<IStoryProlog<TSubject>> self, Func<TSubject, Task> action)
        {
            var prolog = await self;
            return await prolog.And(action);
        }

        public static async Task<IStoryEpilog<TSubject, TResult>> When<TSubject, TResult>(this Task<IStoryProlog<TSubject>> self, Func<TSubject, Task<TResult>> action)
        {
            var prolog = await self;
            return await prolog.When(action);
        }

        public static async Task<IStoryEpilog<TSubject, TResult>> WhenCalling<TSubject, TResult>(this Task<IStoryProlog<TSubject>> self, Func<TSubject, Task<TResult>> action)
        {
            var prolog = await self;
            return await prolog.WhenCalling(action);
        }
    }
}