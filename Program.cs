using System;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new RandomNumberGenerator(1, 100);
            var attemptManager = new AttemptManager(5);
            var io = new ConsoleInputOutput();
            var game = new GuessNumberGame(generator, attemptManager, io);

            game.Start();

            while (attemptManager.HasAttemptsLeft())
            {
                int guess = io.GetInput();
                game.Guess(guess);
                if (!attemptManager.HasAttemptsLeft())
                {
                    io.Output("Игра окончена!");
                    break;
                }
            }
        }
    }
}
