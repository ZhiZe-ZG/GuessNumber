using System;
using CommandLine;

namespace GuessNumber
{
    // This is the entry point of the program. Without any command line parameters, the GUI version of the game will be launched. The command line version of the game can be started via parameters.
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandLineOptions>(args).WithParsed<CommandLineOptions>(Run);
            // var game = new GuessNumberGame();
            // var guessNumber=0;
            // var inputStr = "";
            // bool endGame = false;
            // Console.WriteLine("Welcome to Guess Number!");
            // while (!endGame)
            // {
            //     Console.WriteLine("Please input a number (end with enter):");
            //     inputStr = Console.ReadLine();
            //     try
            //     {
            //         guessNumber=Convert.ToInt32(inputStr);
            //     }
            //     catch
            //     {// handle input error
            //         continue;
            //     }
            //     var guessResult = game.Compare(guessNumber);
            //     if (guessResult is CompareResult.Equal){
            //         endGame = true;
            //         Console.WriteLine("You win!");
            //     }
            //     else{
            //         Console.WriteLine($"Your guess number is {guessResult} than the hidden number.");
            //     }
            // }
            // Console.WriteLine("Game end.");
            // Console.ReadKey();
        }

        public static void Run(CommandLineOptions options)
        {
            // Launch game by choosen mode.
            LaunchMode launchMode;
            if (Enum.TryParse<LaunchMode>(options.Mode, out launchMode))
                switch (launchMode)
                {
                    case LaunchMode.GUI:
                        using (var game = new GameGUI())
                            game.Run();
                        break;
                    case LaunchMode.CLI:
                        Console.WriteLine("CLI Mode");
                        break;

                }
            else
                Console.WriteLine("Unknown launch mode!");
        }
    }
}
