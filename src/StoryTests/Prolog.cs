using System;
using System.Threading.Tasks;

namespace StoryTests
{
    public class Prolog<TContext> where TContext : IDisposable
    {
        private readonly TContext _context;

        public Prolog(TContext context)
        {
            _context = context;
        }

        public Prolog<TContext> With(Action<TContext> action)
        {
            try
            {
                action(_context);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Prolog<TContext>> With(Func<TContext, Task> action)
        {
            try
            {
                await action(_context);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Prolog<TContext> And(Action<TContext> action)
        {
            try
            {
                action(_context);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Prolog<TContext>> And(Func<TContext, Task> action)
        {
            try
            {
                await action(_context);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext>> When(Func<Task> action)
        {
            try
            {
                await action();
                return new Story<TContext>(_context);
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext>> When(Func<TContext, Task> action)
        {
            try
            {
                await action(_context);
                return new Story<TContext>(_context);
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Story<TContext, TResult> When<TResult>(Func<TContext, TResult> action)
        {
            try
            {
                return new Story<TContext, TResult>(_context, action(_context));
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext, TResult>> When<TResult>(Func<TContext, Task<TResult>> action)
        {
            try
            {
                return new Story<TContext, TResult>(_context, await action(_context));
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }
    }
}