using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
    public class Menu : IMenu
    {
        private readonly IOutputWriter _outputWriter;
        private readonly IInputReader _inputReader;
        private readonly ITamagochi _tamagochi;
        public Menu(IOutputWriter outputWriter, IInputReader inputReader, ITamagochi tamagochi)
        {
            _outputWriter = outputWriter;
            _inputReader = inputReader;
            _tamagochi = tamagochi;

        }
        private string menu =
 $@"1-sleep 
2-eat 
3-play";

        public void WriteMenu()
        {
            _outputWriter.Writer(menu);
        }
        public void SelectOperation()
        {
            string option = _inputReader.Reade();
            if (option == "1")
            {
                _tamagochi.Sleep();
            }
            else if (option == "2")
            {
                _tamagochi.Eat();
            }
            else if (option == "3")
            {
                _tamagochi.Play();
            }
            else
            {
                _outputWriter.Writer("Nie ma takiej opcji");

            }
        }

    }
}
