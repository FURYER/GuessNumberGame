using System;
using GuessNumberGame.Interfaces;

namespace GuessNumberGame
{
    public class ConsoleInputOutput : IInputOutput
    {
        public int GetInput()
        {
            while (true)
            {
                Console.Write("Введите число: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    return number;
                }

                Console.WriteLine("Неправильный ввод. Пожалуйста, введите целое число.");
            }
        }

        public void Output(string message)
        {
            Console.WriteLine(message);
        }
    }
}
