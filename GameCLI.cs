using System;

namespace GuessNumber{
    // Play the game on the command line.
    public class GameCLI{
        public void Run(){
            var game = new GuessNumberGame();
            var guessNumber=0;
            var inputStr = "";
            bool endGame = false;
            Console.WriteLine("Welcome to Guess Number!");
            while (!endGame)
            {
                Console.WriteLine("Please input a number (end with enter):");
                inputStr = Console.ReadLine();
                try
                {
                    guessNumber=Convert.ToInt32(inputStr);
                }
                catch
                {// handle input error
                    continue;
                }
                var guessResult = game.Compare(guessNumber);
                if (guessResult is CompareResult.Equal){
                    endGame = true;
                    Console.WriteLine("You win!");
                }
                else{
                    Console.WriteLine($"Your guess number is {guessResult} than the hidden number.");
                }
            }
            Console.WriteLine("Game end.");
            Console.ReadKey();
        }
    }
}