namespace GuessNumberGame
{
    public class AttemptManager
    {
        private readonly int _maxAttempts;
        private int _attempts;

        public AttemptManager(int maxAttempts)
        {
            _maxAttempts = maxAttempts;
            _attempts = 0;
        }

        public void RecordAttempt()
        {
            _attempts++;
        }

        public bool HasAttemptsLeft()
        {
            return _attempts < _maxAttempts;
        }

        public int GetAttemptsLeft()
        {
            return _maxAttempts - _attempts;
        }
    }
}
