using System;
using System.Threading.Tasks;

namespace StoryTests
{
    public static class StoryExtensions
    {
        public static async Task<Story<TContext, TResult>> And<TContext, TResult>(this Task<Story<TContext, TResult>> self, Func<Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.And(func);
        }

        public static async Task<Story<TContext, TResult>> And<TContext, TResult>(this Task<Story<TContext, TResult>> self, Action<TContext> func) where TContext: IDisposable
        {
            var story = await self;
            return story.And(func);
        }

        public static async Task<Story<TContext, TResult>> And<TContext, TResult>(this Task<Story<TContext, TResult>> self, Action<TResult> func) where TContext: IDisposable
        {
            var story = await self;
            return story.And(func);
        }

        public static async Task<Story<TContext, TResult>> And<TContext, TResult>(this Task<Story<TContext, TResult>> self, Func<TResult, Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.And(func);
        }

        public static async Task<Story<TContext, TResult>> And<TContext, TResult>(this Task<Story<TContext, TResult>> self, Func<TContext, Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.And(func);
        }

        public static async Task<Story<TContext, TResult>> And<TContext, TResult>(this Task<Story<TContext, TResult>> self, Func<TContext, TResult, Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.And(func);
        }

        public static async Task<Story<TContext, TResult>> Then<TContext, TResult>(this Task<Story<TContext, TResult>> self, Func<Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.Then(func);
        }

        public static async Task<Story<TContext, TResult>> Then<TContext, TResult>(this Task<Story<TContext, TResult>> self, Func<TResult, Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.Then(func);
        }

        public static async Task<Story<TContext, TResult>> Then<TContext, TResult>(this Task<Story<TContext, TResult>> self, Action<TContext> func) where TContext: IDisposable
        {
            var story = await self;
            return story.Then(func);
        }

        public static async Task<Story<TContext, TResult>> Then<TContext, TResult>(this Task<Story<TContext, TResult>> self, Action<TResult> func) where TContext: IDisposable
        {
            var story = await self;
            return story.Then(func);
        }

        public static async Task<Story<TContext, TResult>> Then<TContext, TResult>(this Task<Story<TContext, TResult>> self, Func<TContext, Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.Then(func);
        }

        public static async Task<Story<TContext, TResult>> Then<TContext, TResult>(this Task<Story<TContext, TResult>> self, Func<TContext, TResult, Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.Then(func);
        }

        public static async Task FinallyDisposeOfContext<TContext, TResult>(this Task<Story<TContext, TResult>> self) where TContext: IDisposable
        {
            var story = await self;
            story.FinallyDisposeOfContext();
        }

        public static async Task<Story<TContext>> And<TContext>(this Task<Story<TContext>> self, Func<Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.And(func);
        }

        public static async Task<Story<TContext>> And<TContext>(this Task<Story<TContext>> self, Func<TContext, Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.And(func);
        }

        public static async Task<Story<TContext>> And<TContext>(this Task<Story<TContext>> self, Action<TContext> func) where TContext: IDisposable
        {
            var story = await self;
            return story.And(func);
        }

        public static async Task<Story<TContext>> Then<TContext>(this Task<Story<TContext>> self, Func<Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.Then(func);
        }

        public static async Task<Story<TContext>> Then<TContext>(this Task<Story<TContext>> self, Func<TContext, Task> func) where TContext: IDisposable
        {
            var story = await self;
            return await story.Then(func);
        }

        public static async Task<Story<TContext>> Then<TContext>(this Task<Story<TContext>> self, Action<TContext> func) where TContext: IDisposable
        {
            var story = await self;
            return story.Then(func);
        }

        public static async Task FinallyDisposeOfContext<TContext>(this Task<Story<TContext>> self) where TContext: IDisposable
        {
            var story = await self;
            story.FinallyDisposeOfContext();
        }
    }
}