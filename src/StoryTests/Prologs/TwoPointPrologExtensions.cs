using System;
using System.Threading.Tasks;
using StoryTests.Epilogs;

namespace StoryTests.Prologs
{
    public static class TwoPointPrologExtensions
    {
        public static async Task<IStoryProlog<TSubject, TService1>> With<TSubject, TService1>(this Task<IStoryProlog<TSubject, TService1>> self, Func<TSubject, Task> action)
        {
            var prolog = await self;
            return await prolog.With(action);
        }

        public static async Task<IStoryProlog<TSubject, TService1>> With<TSubject, TService1>(this Task<IStoryProlog<TSubject, TService1>> self, Func<TService1, Task> action)
        {
            var prolog = await self;
            return await prolog.With(action);
        }

        public static async Task<IStoryProlog<TSubject, TService1>> And<TSubject, TService1>(this Task<IStoryProlog<TSubject, TService1>> self, Func<TSubject, Task> action)
        {
            var prolog = await self;
            return await prolog.And(action);
        }

        public static async Task<IStoryProlog<TSubject, TService1>> And<TSubject, TService1>(this Task<IStoryProlog<TSubject, TService1>> self, Func<TService1, Task> action)
        {
            var prolog = await self;
            return await prolog.And(action);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TResult>> When<TSubject, TService1, TResult>(this Task<IStoryProlog<TSubject, TService1>> self, Func<TSubject, Task<TResult>> action)
        {
            var prolog = await self;
            return await prolog.When(action);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TResult>> WhenCalling<TSubject, TService1, TResult>(this Task<IStoryProlog<TSubject, TService1>> self, Func<TSubject, Task<TResult>> action)
        {
            var prolog = await self;
            return await prolog.WhenCalling(action);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TResult>> WhenCalling<TSubject, TService1, TResult>(this Task<IStoryProlog<TSubject, TService1>> self, Func<TSubject, TService1, Task<TResult>> action)
        {
            var prolog = await self;
            return await prolog.WhenCalling(action);
        }
    }
}