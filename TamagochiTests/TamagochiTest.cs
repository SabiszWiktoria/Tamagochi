using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Tamagochi;

namespace TamagochiTests
{
    class TamagochiTest
    {

        [Test]
        public void Sleep_recovers_8_energy()
        {
            // Arrange
            var eventListnerSpy = new EventListnerSpy(); // Tworzymy szpiega!
            var tamagochi = new Tamagochi.Tamagochi(eventListnerSpy);

            // Act
            tamagochi.Sleep();

            // Assert
            var energyAfterSleep = eventListnerSpy.CurrentEnergy; // pytamy szpiega w jakim stanie jest nasz obiekt

            Assert.That(energyAfterSleep == 8);
        }

        [Test]
        public void Sleep_publish_status_after_sleeping()
        {
            // Arrange
            var eventListnerSpy = new EventListnerSpy();
            var tamagochi = new Tamagochi.Tamagochi(eventListnerSpy);

            // Act
            tamagochi.Sleep();

            // Assert
            eventListnerSpy.RecivedPublish();
        }
    }

    // nasz szpieg
    // podstawiamy go zamiast listnera i możemy podglądać statusy naszego tamagochi
    internal class EventListnerSpy : IEventPublisher
    {
        public TamagochiStatus CurrentStatus { get; private set; }

        public int CurrentEnergy => CurrentStatus.energy;
        public int CurrentHunger => CurrentStatus.hunger;
        public int CurrentHappiness => CurrentStatus.happiness;

        private int _publishCount = 0;

        public void Publish(string status)
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

