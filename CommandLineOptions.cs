using CommandLine;

namespace GuessNumber{
    // Configuration used for command line parsing.
    public class CommandLineOptions{
        [Option('m', Default = (string)"GUI")]
        public string Mode{get; set;}
    }

    public enum LaunchMode{GUI, CLI}
}