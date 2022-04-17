using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
  public  interface IEventPublisher
    {
        public void Publish(string status);
    }
}
