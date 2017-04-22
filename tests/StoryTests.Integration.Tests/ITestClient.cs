namespace StoryTests.Integration.Tests
{
    public interface ITestClient
    {
        void With();
        void And();
        int WhenCalling();
        int Then();
    }
}