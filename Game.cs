using System;

namespace GuessNumber
{
    enum CompareResult { Bigger, Smaller, Equal } //the input number is bigger, smaller or equal to the hidden number
    class Game
    {
        // The number to guess
        public int HiddenNumber { get; private set; }
        public Game(int minValue = 1, int maxValue = 100)
        {
            // hidden number is bigger or equal to minValue
            // less or equal to maxValue
            var rand = new Random();
            HiddenNumber = rand.Next(minValue, maxValue + 1);
        }
        public CompareResult Compare(int guess)
        {
            if (guess < HiddenNumber)
            {
                return CompareResult.Smaller;
            }
            if (guess == HiddenNumber)
            {
                return CompareResult.Equal;
            }
            return CompareResult.Bigger;
        }
    }
}