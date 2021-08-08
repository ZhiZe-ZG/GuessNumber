using System;

namespace GuessNumber
{
    class Game
    {
        // The number to guess
        public int HiddenNumber { get; private set; }
        public Game()
        {
            HiddenNumber = 2;
        }
        public static void hello()
        {
            System.Console.WriteLine("Hello Game!");
        }
    }
}