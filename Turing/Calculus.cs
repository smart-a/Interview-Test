namespace Turing
{
    public class Calculus
    {
        private readonly int _firstNumber;
        private readonly int _secondNumber;

        public Calculus(int firstNumber, int secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }

        public int GetSum()
        {
            return _firstNumber + _secondNumber;
        }
    }
}