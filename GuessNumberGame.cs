using GuessNumberGame.Interfaces;

namespace GuessNumberGame
{
    public class GuessNumberGame : IGame
    {
        private readonly RandomNumberGenerator _generator;
        private readonly AttemptManager _attemptManager;
        private readonly IInputOutput _io;
        private int _targetNumber;

        public GuessNumberGame(RandomNumberGenerator generator, AttemptManager attemptManager, IInputOutput io)
        {
            _generator = generator;
            _attemptManager = attemptManager;
            _io = io;
        }

        public void Start()
        {
            _targetNumber = _generator.Generate();
            _io.Output("Игра началась! Угадайте число.");
        }

        public void Guess(int number)
        {
            if (!_attemptManager.HasAttemptsLeft())
            {
                _io.Output("У вас не осталось попыток!");
                return;
            }

            _attemptManager.RecordAttempt();

            if (number < _targetNumber)
            {
                _io.Output("Загаданное число больше.");
            }
            else if (number > _targetNumber)
            {
                _io.Output("Загаданное число меньше.");
            }
            else
            {
                _io.Output("Поздравляем! Вы угадали число.");
                return;
            }

            if (!_attemptManager.HasAttemptsLeft())
            {
                _io.Output($"Вы исчерпали все попытки. Загаданное число было {_targetNumber}.");
            }
        }
    }
}
