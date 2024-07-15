using System;

namespace GuessNumberGame
{
    public class RandomNumberGenerator
    {
        private readonly int _lower;
        private readonly int _upper;

        public RandomNumberGenerator(int lower, int upper)
        {
            _lower = lower;
            _upper = upper;
        }

        public int Generate()
        {
            Random random = new Random();
            return random.Next(_lower, _upper + 1);
        }
    }
}