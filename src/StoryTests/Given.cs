using System.Threading.Tasks;

namespace StoryTests
{
    public class Given
    {
        public static async Task<Prolog<TContext>> A<TContext>() where TContext : IContext, new()
        {
            var context = new TContext();
            await context.Initialise();
            return new Prolog<TContext>(context);
        }

        public static Prolog<TContext> A<TContext>(TContext context) where TContext : IContext
        {
            return new Prolog<TContext>(context);
        }
    }
}