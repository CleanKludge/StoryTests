using System;
using System.Threading.Tasks;
using StoryTests.Epilogs;

namespace StoryTests.Prologs
{
    public static class FourPointPrologExtensions
    {
        public static async Task<IStoryProlog<TSubject, TService1, TService2, TService3>> With<TSubject, TService1, TService2, TService3>(this Task<IStoryProlog<TSubject, TService1, TService2, TService3>> self, Func<TSubject, Task> action)
        {
            var prolog = await self;
            return await prolog.With(action);
        }

        public static async Task<IStoryProlog<TSubject, TService1, TService2, TService3>> With<TSubject, TService1, TService2, TService3>(this Task<IStoryProlog<TSubject, TService1, TService2, TService3>> self, Func<TService1, Task> action)
        {
            var prolog = await self;
            return await prolog.With(action);
        }

        public static async Task<IStoryProlog<TSubject, TService1, TService2, TService3>> With<TSubject, TService1, TService2, TService3>(this Task<IStoryProlog<TSubject, TService1, TService2, TService3>> self, Func<TService2, Task> action)
        {
            var prolog = await self;
            return await prolog.With(action);
        }

        public static async Task<IStoryProlog<TSubject, TService1, TService2, TService3>> With<TSubject, TService1, TService2, TService3>(this Task<IStoryProlog<TSubject, TService1, TService2, TService3>> self, Func<TService3, Task> action)
        {
            var prolog = await self;
            return await prolog.With(action);
        }

        public static async Task<IStoryProlog<TSubject, TService1, TService2, TService3>> And<TSubject, TService1, TService2, TService3>(this Task<IStoryProlog<TSubject, TService1, TService2, TService3>> self, Func<TSubject, Task> action)
        {
            var prolog = await self;
            return await prolog.And(action);
        }

        public static async Task<IStoryProlog<TSubject, TService1, TService2, TService3>> And<TSubject, TService1, TService2, TService3>(this Task<IStoryProlog<TSubject, TService1, TService2, TService3>> self, Func<TService1, Task> action)
        {
            var prolog = await self;
            return await prolog.And(action);
        }

        public static async Task<IStoryProlog<TSubject, TService1, TService2, TService3>> And<TSubject, TService1, TService2, TService3>(this Task<IStoryProlog<TSubject, TService1, TService2, TService3>> self, Func<TService2, Task> action)
        {
            var prolog = await self;
            return await prolog.And(action);
        }

        public static async Task<IStoryProlog<TSubject, TService1, TService2, TService3>> And<TSubject, TService1, TService2, TService3>(this Task<IStoryProlog<TSubject, TService1, TService2, TService3>> self, Func<TService3, Task> action)
        {
            var prolog = await self;
            return await prolog.And(action);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> When<TSubject, TService1, TService2, TService3, TResult>(this Task<IStoryProlog<TSubject, TService1, TService2, TService3>> self, Func<TSubject, Task<TResult>> action)
        {
            var prolog = await self;
            return await prolog.When(action);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> WhenCalling<TSubject, TService1, TService2, TService3, TResult>(this Task<IStoryProlog<TSubject, TService1, TService2, TService3>> self, Func<TSubject, Task<TResult>> action)
        {
            var prolog = await self;
            return await prolog.WhenCalling(action);
        }

        public static async Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> WhenCalling<TSubject, TService1, TService2, TService3, TResult>(this Task<IStoryProlog<TSubject, TService1, TService2, TService3>> self, Func<TSubject, TService1, TService2, TService3, Task<TResult>> action)
        {
            var prolog = await self;
            return await prolog.WhenCalling(action);
        }
    }
}