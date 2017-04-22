using System;
using System.Threading.Tasks;
using StoryTests.Epilogs;

namespace StoryTests.Prologs
{
    public interface IStoryProlog<TSubject>
    {
        IStoryProlog<TSubject> With(Action<TSubject> action);
        IStoryProlog<TSubject> And(Action<TSubject> action);
        IStoryEpilog<TSubject, TResult> When<TResult>(Func<TSubject, TResult> action);
        IStoryEpilog<TSubject, TResult> WhenCalling<TResult>(Func<TSubject, TResult> action);

        Task<IStoryProlog<TSubject>> With(Func<TSubject, Task> action);
        Task<IStoryProlog<TSubject>> And(Func<TSubject, Task> action);
        Task<IStoryEpilog<TSubject, TResult>> When<TResult>(Func<TSubject, Task<TResult>> action);
        Task<IStoryEpilog<TSubject, TResult>> WhenCalling<TResult>(Func<TSubject, Task<TResult>> action);
    }

    public interface IStoryProlog<TSubject, TService1>
    {
        IStoryProlog<TSubject, TService1> With(Action<TSubject> action);
        IStoryProlog<TSubject, TService1> With(Action<TService1> action);
        IStoryProlog<TSubject, TService1> And(Action<TSubject> action);
        IStoryProlog<TSubject, TService1> And(Action<TService1> action);
        IStoryEpilog<TSubject, TService1, TResult> When<TResult>(Func<TSubject, TResult> action);
        IStoryEpilog<TSubject, TService1, TResult> WhenCalling<TResult>(Func<TSubject, TResult> action);
        IStoryEpilog<TSubject, TService1, TResult> WhenCalling<TResult>(Func<TSubject, TService1, TResult> action);

        Task<IStoryProlog<TSubject, TService1>> With(Func<TSubject, Task> action);
        Task<IStoryProlog<TSubject, TService1>> With(Func<TService1, Task> action);
        Task<IStoryProlog<TSubject, TService1>> And(Func<TSubject, Task> action);
        Task<IStoryProlog<TSubject, TService1>> And(Func<TService1, Task> action);
        Task<IStoryEpilog<TSubject, TService1, TResult>> When<TResult>(Func<TSubject, Task<TResult>> action);
        Task<IStoryEpilog<TSubject, TService1, TResult>> WhenCalling<TResult>(Func<TSubject, Task<TResult>> action);
        Task<IStoryEpilog<TSubject, TService1, TResult>> WhenCalling<TResult>(Func<TSubject, TService1, Task<TResult>> action);
    }

    public interface IStoryProlog<TSubject, TService1, TService2>
    {
        IStoryProlog<TSubject, TService1, TService2> With(Action<TSubject> action);
        IStoryProlog<TSubject, TService1, TService2> With(Action<TService1> action);
        IStoryProlog<TSubject, TService1, TService2> With(Action<TService2> action);
        IStoryProlog<TSubject, TService1, TService2> And(Action<TSubject> action);
        IStoryProlog<TSubject, TService1, TService2> And(Action<TService1> action);
        IStoryProlog<TSubject, TService1, TService2> And(Action<TService2> action);
        IStoryEpilog<TSubject, TService1, TService2, TResult> When<TResult>(Func<TSubject, TResult> action);
        IStoryEpilog<TSubject, TService1, TService2, TResult> WhenCalling<TResult>(Func<TSubject, TResult> action);
        IStoryEpilog<TSubject, TService1, TService2, TResult> WhenCalling<TResult>(Func<TSubject, TService1, TService2, TResult> action);

        Task<IStoryProlog<TSubject, TService1, TService2>> With(Func<TSubject, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2>> With(Func<TService1, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2>> With(Func<TService2, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2>> And(Func<TSubject, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2>> And(Func<TService1, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2>> And(Func<TService2, Task> action);
        Task<IStoryEpilog<TSubject, TService1, TService2, TResult>> When<TResult>(Func<TSubject, Task<TResult>> action);
        Task<IStoryEpilog<TSubject, TService1, TService2, TResult>> WhenCalling<TResult>(Func<TSubject, Task<TResult>> action);
        Task<IStoryEpilog<TSubject, TService1, TService2, TResult>> WhenCalling<TResult>(Func<TSubject, TService1, TService2, Task<TResult>> action);
    }

    public interface IStoryProlog<TSubject, TService1, TService2, TService3>
    {
        IStoryProlog<TSubject, TService1, TService2, TService3> With(Action<TSubject> action);
        IStoryProlog<TSubject, TService1, TService2, TService3> With(Action<TService1> action);
        IStoryProlog<TSubject, TService1, TService2, TService3> With(Action<TService2> action);
        IStoryProlog<TSubject, TService1, TService2, TService3> With(Action<TService3> action);
        IStoryProlog<TSubject, TService1, TService2, TService3> And(Action<TSubject> action);
        IStoryProlog<TSubject, TService1, TService2, TService3> And(Action<TService1> action);
        IStoryProlog<TSubject, TService1, TService2, TService3> And(Action<TService2> action);
        IStoryProlog<TSubject, TService1, TService2, TService3> And(Action<TService3> action);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TResult> When<TResult>(Func<TSubject, TResult> action);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TResult> WhenCalling<TResult>(Func<TSubject, TResult> action);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TResult> WhenCalling<TResult>(Func<TSubject, TService1, TService2, TService3, TResult> action);

        Task<IStoryProlog<TSubject, TService1, TService2, TService3>> With(Func<TSubject, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3>> With(Func<TService1, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3>> With(Func<TService2, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3>> With(Func<TService3, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3>> And(Func<TSubject, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3>> And(Func<TService1, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3>> And(Func<TService2, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3>> And(Func<TService3, Task> action);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> When<TResult>(Func<TSubject, Task<TResult>> action);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> WhenCalling<TResult>(Func<TSubject, Task<TResult>> action);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TResult>> WhenCalling<TResult>(Func<TSubject, TService1, TService2, TService3, Task<TResult>> action);
    }

    public interface IStoryProlog<TSubject, TService1, TService2, TService3, TService4>
    {
        IStoryProlog<TSubject, TService1, TService2, TService3, TService4> With(Action<TSubject> action);
        IStoryProlog<TSubject, TService1, TService2, TService3, TService4> With(Action<TService1> action);
        IStoryProlog<TSubject, TService1, TService2, TService3, TService4> With(Action<TService2> action);
        IStoryProlog<TSubject, TService1, TService2, TService3, TService4> With(Action<TService3> action);
        IStoryProlog<TSubject, TService1, TService2, TService3, TService4> With(Action<TService4> action);
        IStoryProlog<TSubject, TService1, TService2, TService3, TService4> And(Action<TSubject> action);
        IStoryProlog<TSubject, TService1, TService2, TService3, TService4> And(Action<TService1> action);
        IStoryProlog<TSubject, TService1, TService2, TService3, TService4> And(Action<TService2> action);
        IStoryProlog<TSubject, TService1, TService2, TService3, TService4> And(Action<TService3> action);
        IStoryProlog<TSubject, TService1, TService2, TService3, TService4> And(Action<TService4> action);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> When<TResult>(Func<TSubject, TResult> action);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> WhenCalling<TResult>(Func<TSubject, TResult> action);
        IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult> WhenCalling<TResult>(Func<TSubject, TService1, TService2, TService3, TService4, TResult> action);

        Task<IStoryProlog<TSubject, TService1, TService2, TService3, TService4>> With(Func<TSubject, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3, TService4>> With(Func<TService1, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3, TService4>> With(Func<TService2, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3, TService4>> With(Func<TService3, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3, TService4>> With(Func<TService4, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3, TService4>> And(Func<TSubject, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3, TService4>> And(Func<TService1, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3, TService4>> And(Func<TService2, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3, TService4>> And(Func<TService3, Task> action);
        Task<IStoryProlog<TSubject, TService1, TService2, TService3, TService4>> And(Func<TService4, Task> action);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> When<TResult>(Func<TSubject, Task<TResult>> action);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> WhenCalling<TResult>(Func<TSubject, Task<TResult>> action);
        Task<IStoryEpilog<TSubject, TService1, TService2, TService3, TService4, TResult>> WhenCalling<TResult>(Func<TSubject, TService1, TService2, TService3, TService4, Task<TResult>> action);
    }
}