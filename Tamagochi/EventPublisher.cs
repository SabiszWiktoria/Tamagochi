using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
    public class EventPublisher : IEventPublisher
    {
        private readonly IOutputWriter _outputWriter;
        public EventPublisher(IOutputWriter outputWriter)
        {
            _outputWriter = outputWriter;
        }
        public void Publish(string status)
        {
            _outputWriter.Writer(status);
        }
    }
}
