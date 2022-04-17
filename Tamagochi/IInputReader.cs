using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
    public interface IInputReader
    {
        public string Reade();
    }

    public class InputReader : IInputReader
    {
        public string Reade()
        {
            string inputReader;
            inputReader = Console.ReadLine();
            return inputReader;
        }
    }
}
