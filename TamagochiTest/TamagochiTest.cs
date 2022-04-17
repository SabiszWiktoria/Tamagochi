using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tamagochi;

namespace TamagochiTest
{
    class TamagochiTest
    {
        [Test]
        public void Sleep_recovers_80_energy()
        {
            // Arrange
            var eventListnerSpy = new EventListnerSpy(); // Tworzymy szpiega!
            var tamagochi = new Tamagochi(eventListnerSpy);

            // Act
            tamagochi.Sleep();

            // Assert
            var energyAfterSleep = eventListnerSpy.CurrentEnergy; // pytamy szpiega w jakim stanie jest nasz obiekt

            Assert.That(energyAfterSleep == 80);
        }

        [Test]
        public void Sleep_publish_status_after_sleeping()
        {
            // Arrange
            var eventListnerSpy = new EventListnerSpy();
            var tamagochi = new Tamagochi(eventListnerSpy);

            // Act
            tamagochi.Sleep();

            // Assert
            eventListnerSpy.RecivedPublish();
        }
    }

    // nasz szpieg
    // podstawiamy go zamiast listnera i możemy podglądać statusy naszego tamagochi
    internal class EventListnerSpy : IListener
    {
        public TamagochiStatus CurrentStatus { get; private set; }

        public int CurrentEnergy => CurrentStatus.Energy;
        public int CurrentHunger => CurrentStatus.Hunger;
        public int CurrentHappiness => CurrentStatus.Happiness;

        private int _publishCount = 0;

        public void Publish(TamagochiStatus status)
        {
            CurrentStatus = CurrentStatus;
            _publishCount++;
        }

        public EventListnerSpy RecivedPublish(int count = 1)
        {
            Assert.That(_publishCount == count);
            return this;
        }
    }
}
