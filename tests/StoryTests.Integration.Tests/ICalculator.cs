using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace StoryTests.Integration.Tests
{
    public interface ICalculator
    {
        void Add(int data);
        CalculateResult Sum();
    }

    public class Calculator : ICalculator
    {
        private readonly List<int> _numbers;

        public Calculator()
        {
            _numbers = new List<int>();
        }

        public void Add(int data)
        {
            _numbers.Add(data);
        }

        public CalculateResult Sum()
        {
            return new CalculateResult { Value = _numbers.Sum() };
        }
    }
}