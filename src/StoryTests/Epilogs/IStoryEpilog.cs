using System;
using System.Threading.Tasks;

namespace StoryTests.Epilogs
{
    public interface IStoryEpilog<TSubject, TResult>
    {
        IStoryEpilog<TSubject, TOut> ThenCalling<TOut>(Func<TSubject, TResult, TOut> func);
        IStoryEpilog<TSubject, TResult> Then(Action<TSubject, TResult> func);
        IStoryEpilog<TSubject, TResult> Then(Action<TResult> func);
        TOut ThenReturn<TOut>(Func<TResult, TOut> func);
        TResult ThenReturnTheResult();

        Task<IStoryEpilog<TSubject, TOut>> ThenCalling<TOut>(Func<TSubject, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TResult>> Then(Func<TSubject, TResult, Task> func);
        Task<IStoryEpilog<TSubject, TResult>> Then(Func<TResult, Task> func);
        Task<TOut> ThenReturn<TOut>(Func<TResult, Task<TOut>> func);
    }
 
    public interface IStoryEpilog<TSubject, TService1, TResult>
    {
        IStoryEpilog<TSubject, TService1, TOut> ThenCalling<TOut>(Func<TSubject, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TOut> ThenCalling<TOut>(Func<TService1, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TResult> Then(Action<TResult> func);
        IStoryEpilog<TSubject, TService1, TResult> Then(Action<TSubject, TResult> func);
        IStoryEpilog<TSubject, TService1, TResult> Then(Action<TService1, TResult> func);
        TOut ThenReturn<TOut>(Func<TResult, TOut> func);
        TResult ThenReturnTheResult();

        Task<IStoryEpilog<TSubject, TService1, TOut>> ThenCalling<TOut>(Func<TSubject, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TOut>> ThenCalling<TOut>(Func<TService1, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TResult>> Then(Func<TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TResult>> Then(Func<TSubject, TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TResult>> Then(Func<TService1, TResult, Task> func);
        Task<TOut> ThenReturn<TOut>(Func<TResult, Task<TOut>> func);
    }
 
    public interface IStoryEpilog<TSubject, TService1, TService2, TResult>
    {
        IStoryEpilog<TSubject, TService1, TService2, TOut> ThenCalling<TOut>(Func<TSubject, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TOut> ThenCalling<TOut>(Func<TService1, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TOut> ThenCalling<TOut>(Func<TService2, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TResult> Then(Action<TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TResult> Then(Action<TSubject, TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TResult> Then(Action<TService1, TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TResult> Then(Action<TService2, TResult> func);
        TOut ThenReturn<TOut>(Func<TResult, TOut> func);
        TResult ThenReturnTheResult();

        Task<IStoryEpilog<TSubject, TService1, TService2, TOut>> ThenCalling<TOut>(Func<TSubject, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TOut>> ThenCalling<TOut>(Func<TService1, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TOut>> ThenCalling<TOut>(Func<TService2, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TResult>> Then(Func<TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TResult>> Then(Func<TSubject, TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TResult>> Then(Func<TService1, TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TResult>> Then(Func<TService2, TResult, Task> func);
        Task<TOut> ThenReturn<TOut>(Func<TResult, Task<TOut>> func);
    }

    public interface IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>
    {
        IStoryEpilog<TSubject, TService1, TService2, TService3, TOut> ThenCalling<TOut>(Func<TSubject, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TOut> ThenCalling<TOut>(Func<TService1, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TOut> ThenCalling<TOut>(Func<TService2, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TOut> ThenCalling<TOut>(Func<TService3, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TResult> Then(Action< TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TResult> Then(Action<TSubject, TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TResult> Then(Action<TService1, TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TResult> Then(Action<TService2, TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TResult> Then(Action<TService3, TResult> func);
        TOut ThenReturn<TOut>(Func<TResult, TOut> func);
        TResult ThenReturnTheResult();

        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> ThenCalling<TOut>(Func<TSubject, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> ThenCalling<TOut>(Func<TService1, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> ThenCalling<TOut>(Func<TService2, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TOut>> ThenCalling<TOut>(Func<TService3, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> Then(Func<TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> Then(Func<TSubject, TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> Then(Func<TService1, TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> Then(Func<TService2, TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> Then(Func<TService3, TResult, Task> func);
        Task<TOut> ThenReturn<TOut>(Func<TResult, Task<TOut>> func);
    }

    public interface IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>
    {
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut> ThenCalling<TOut>(Func<TSubject, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut> ThenCalling<TOut>(Func<TService1, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut> ThenCalling<TOut>(Func<TService2, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut> ThenCalling<TOut>(Func<TService3, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut> ThenCalling<TOut>(Func<TService4, TResult, TOut> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TSubject, TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TService1, TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TService2, TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TService3, TResult> func);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> Then(Action<TService4, TResult> func);
        TOut ThenReturn<TOut>(Func<TResult, TOut> func);
        TResult ThenReturnTheResult();

        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>> ThenCalling<TOut>(Func<TSubject, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>> ThenCalling<TOut>(Func<TService1, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>> ThenCalling<TOut>(Func<TService2, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>> ThenCalling<TOut>(Func<TService3, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TOut>> ThenCalling<TOut>(Func<TService4, TResult, Task<TOut>> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TSubject, TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TService1, TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TService2, TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TService3, TResult, Task> func);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> Then(Func<TService4, TResult, Task> func);
        Task<TOut> ThenReturn<TOut>(Func<TResult, Task<TOut>> func);
    }
}