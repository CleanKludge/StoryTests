using StoryTests.Prologs;

namespace StoryTests
{
    public class Given
    {
        public static IStoryProlog<TSubject> ANewStoryAbout<TSubject>(TSubject subject)
        {
            return new OnePointProlog<TSubject>(subject);
        }

        public static IStoryProlog<TSubject, TService1> ANewStoryAbout<TSubject, TService1>(TSubject subject, TService1 service1)
        {
            return new TwoPointProlog<TSubject, TService1>(subject, service1);
        }

        public static IStoryProlog<TSubject, TService1, TService2> ANewStoryAbout<TSubject, TService1, TService2>(TSubject subject, TService1 service1, TService2 service2)
        {
            return new ThreePointProlog<TSubject, TService1, TService2>(subject, service1, service2);
        }

        public static IStoryProlog<TSubject, TService1, TService2, TService3> ANewStoryAbout<TSubject, TService1, TService2, TService3>(TSubject subject, TService1 service1, TService2 service2, TService3 service3)
        {
            return new FourPointProlog<TSubject, TService1, TService2, TService3>(subject, service1, service2, service3);
        }

        public static IStoryProlog<TSubject, TService1, TService2, TService3, TService4> ANewStoryAbout<TSubject, TService1, TService2, TService3, TService4>(TSubject subject, TService1 service1, TService2 service2, TService3 service3, TService4 service4)
        {
            return new FivePointProlog<TSubject, TService1, TService2, TService3, TService4>(subject, service1, service2, service3, service4);
        }
    }
}