﻿using System;
using System.Threading.Tasks;

namespace StoryTests
{
    public class Given
    {
        public static async Task<Prolog<TContext>> A<TContext>() where TContext : IStoryContext, new()
        {
            var context = new TContext();
            await context.Initialise();
            return new Prolog<TContext>(context);
        }

        public static Prolog<TContext> A<TContext>(TContext context) where TContext : IDisposable
        {
            return new Prolog<TContext>(context);
        }
    }
}