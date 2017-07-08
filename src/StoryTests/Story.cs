using System;
using System.Threading.Tasks;

namespace StoryTests
{
    public class Story<TContext, TResult> where TContext : IDisposable
    {
        private readonly TResult _response;
        private readonly TContext _context;

        public Story(TContext context, TResult response)
        {
            _context = context;
            _response = response;
        }

        public Story<TContext, TResult> And(Action<TResult> func)
        {
            try
            {
                func(_response);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext, TResult>> And(Func<TResult, Task> func)
        {
            try
            {
                await func(_response);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Story<TContext, TResult> And(Action<TContext> func)
        {
            try
            {
                func(_context);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext, TResult>> And(Func<TContext, Task> func)
        {
            try
            {
                await func(_context);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Story<TContext, TResult> And(Action<TContext, TResult> func)
        {
            try
            {
                func(_context, _response);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext, TResult>> And(Func<TContext, TResult, Task> func)
        {
            try
            {
                await func(_context, _response);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }


        public Story<TContext, TResult> And(Action func)
        {
            try
            {
                func();
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext, TResult>> And(Func<Task> func)
        {
            try
            {
                await func();
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Story<TContext, TResult> Then(Action<TContext> func)
        {
            try
            {
                func(_context);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext, TResult>> Then(Func<TContext, Task> func)
        {
            try
            {
                await func(_context);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Story<TContext, TResult> Then(Action<TResult> func)
        {
            try
            {
                func(_response);
                return new Story<TContext, TResult>(_context, _response);
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext, TResult>> Then(Func<TResult, Task> func)
        {
            try
            {
                await func(_response);
                return new Story<TContext, TResult>(_context, _response);
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Story<TContext, TResult> Then(Action<TContext, TResult> func)
        {
            try
            {
                func(_context, _response);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext, TResult>> Then(Func<TContext, TResult, Task> func)
        {
            try
            {
                await func(_context, _response);
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Story<TContext, TResult> Then(Action func)
        {
            try
            {
                func();
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext, TResult>> Then(Func<Task> func)
        {
            try
            {
                await func();
                return this;
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public void FinallyDisposeOfContext()
        {
            _context.Dispose();
        }
    }

    public class Story<TContext> where TContext : IDisposable
    {
        private readonly TContext _context;

        public Story(TContext context)
        {
            _context = context;
        }

        public Story<TContext> And(Action func)
        {
            try
            {
                func();
                return this;
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext>> And(Func<Task> func)
        {
            try
            {
                await func();
                return this;
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Story<TContext> And(Action<TContext> func)
        {
            try
            {
                func(_context);
                return this;
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext>> And(Func<TContext, Task> func)
        {
            try
            {
                await func(_context);
                return this;
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Story<TContext> Then(Action func)
        {
            try
            {
                func();
                return this;
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Story<TContext> Then(Action<TContext> func)
        {
            try
            {
                func(_context);
                return this;
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext>> Then(Func<Task> func)
        {
            try
            {
                await func();
                return this;
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext>> Then(Func<TContext, Task> func)
        {
            try
            {
                await func(_context);
                return this;
            }
            catch (Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public void FinallyDisposeOfContext()
        {
            _context.Dispose();
        }
    }
}