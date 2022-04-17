using System;

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            IOutputWriter outputWriter = new OutputWriter();
            IInputReader inputReader = new InputReader();
            IEventPublisher eventPublisher =new EventPublisher(outputWriter);
            ITamagochi tamagochi = new Tamagochi(eventPublisher);
            Menu menu = new Menu(outputWriter,inputReader,tamagochi);
            Console.WriteLine("Tamagochi wita");
            do
            {
                menu.WriteMenu();
                menu.SelectOperation();
            } while (1==1);
        }
      
    }
}
