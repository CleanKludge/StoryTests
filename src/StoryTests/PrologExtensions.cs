using System;
using System.Threading.Tasks;

namespace StoryTests
{
    public static class PrologExtensions
    {
        public static async Task<Prolog<TContext>> With<TContext>(this Task<Prolog<TContext>> self, Func<TContext, Task> action) where TContext : IDisposable
        {
            var prolog = await self;
            return await prolog.With(action);
        }

        public static async Task<Prolog<TContext>> And<TContext>(this Task<Prolog<TContext>> self, Func<TContext, Task> action) where TContext : IDisposable
        {
            var prolog = await self;
            return await prolog.And(action);
        }

        public static async Task<Story<TContext, TResult>> When<TContext, TResult>(this Task<Prolog<TContext>> self, Func<TContext, Task<TResult>> action) where TContext : IDisposable
        {
            var prolog = await self;
            return await prolog.When(action);
        }

        public static async Task<Story<TContext>> When<TContext>(this Task<Prolog<TContext>> self, Func<Task> action) where TContext : IDisposable
        {
            var prolog = await self;
            return await prolog.When(action);
        }

        public static async Task<Story<TContext>> When<TContext>(this Task<Prolog<TContext>> self, Func<TContext, Task> action) where TContext : IDisposable
        {
            var prolog = await self;
            return await prolog.When(action);
        }
    }
}