using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
    public class Tamagochi : ITamagochi
    {
        private readonly IEventPublisher _publisher;

        public Tamagochi(IEventPublisher publisher)
        {
            _publisher = publisher;
        }

        private int _hunger=5;
        private int _happiness=5;
        private int _energy=5;

      
        public void Eat()
        {
            PublishStatus(-1,0,0);
        }

        public void Play()
        {
            PublishStatus(1,1,-1);
        }

        public void Sleep()
        {
            PublishStatus(1, -1, 1);
        }
        private void PublishStatus(int hunger,int  happiness, int energy)
        {
            _hunger += hunger;
            _happiness += happiness;
            _energy += energy;
            var tamagochiStatus = new TamagochiStatus(_energy,_hunger, _happiness );
            _publisher.Publish(tamagochiStatus.ReturnStatus());
        }
    }
}
