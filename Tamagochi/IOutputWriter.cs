using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
  public  interface IOutputWriter
    {
        public void Writer(string output);
    }

    public class OutputWriter : IOutputWriter
    {
        public void Writer(string output)
        {
            Console.WriteLine(output);
        }
    }
}
