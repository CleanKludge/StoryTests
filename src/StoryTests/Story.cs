using System;
using System.Threading.Tasks;

namespace StoryTests
{
    public class Story<TContext, TResponse> where TContext : IContext
    {
        private readonly TResponse _response;
        private readonly TContext _context;

        public Story(TContext context, TResponse response)
        {
            _context = context;
            _response = response;
        }

        public Story<TContext, TResponse> And(Action<TResponse> func)
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

        public async Task<Story<TContext, TResponse>> And(Func<TResponse, Task> func)
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

        public Story<TContext, TResponse> And(Action<TContext> func)
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

        public async Task<Story<TContext, TResponse>> And(Func<TContext, Task> func)
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

        public Story<TContext, TResponse> And(Action<TContext, TResponse> func)
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

        public async Task<Story<TContext, TResponse>> And(Func<TContext, TResponse, Task> func)
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


        public Story<TContext, TResponse> And(Action func)
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

        public async Task<Story<TContext, TResponse>> And(Func<Task> func)
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

        public Story<TContext, TResponse> Then(Action<TContext> func)
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

        public async Task<Story<TContext, TResponse>> Then(Func<TContext, Task> func)
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

        public Story<TContext, TResponse> Then(Action<TResponse> func)
        {
            try
            {
                func(_response);
                return new Story<TContext, TResponse>(_context, _response);
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public async Task<Story<TContext, TResponse>> Then(Func<TResponse, Task> func)
        {
            try
            {
                await func(_response);
                return new Story<TContext, TResponse>(_context, _response);
            }
            catch(Exception)
            {
                _context.Dispose();
                throw;
            }
        }

        public Story<TContext, TResponse> Then(Action<TContext, TResponse> func)
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

        public async Task<Story<TContext, TResponse>> Then(Func<TContext, TResponse, Task> func)
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

        public Story<TContext, TResponse> Then(Action func)
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

        public async Task<Story<TContext, TResponse>> Then(Func<Task> func)
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

    public class Story<TContext> where TContext : IContext
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