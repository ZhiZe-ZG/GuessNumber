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
            
        }

        public static void Run(CommandLineOptions options)
        {
            // Launch game by choosen mode.
            LaunchMode launchMode;
            if (Enum.TryParse<LaunchMode>(options.Mode, out launchMode))
                switch (launchMode)
                {
                    case LaunchMode.GUI:
                        using (var gameGUI = new GameGUI())
                            gameGUI.Run();
                        break;
                    case LaunchMode.CLI:
                        var gameCLI = new GameCLI();
                        gameCLI.Run();
                        break;

                }
            else
                Console.WriteLine("Unknown launch mode!");
        }
    }
}
