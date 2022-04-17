using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
  public  class TamagochiStatus
    {
        public int energy { get; }
        public int hunger { get; }
        public int happiness { get; }
       

        public TamagochiStatus(int _energy, int _hunger, int _happiness)
        {
            energy = _energy;
            hunger = _hunger;
            happiness = _happiness;
        }
        
        public string ReturnStatus()
        {
            string status = $@"energy {energy}, hunger {hunger}, happiness {happiness} ";
            if (energy == 0)
            {
                status = "Twoj tamagochci zmarl z wycienczenia";
            }
            else if (hunger == 10)
            {
                status = "Twoj tamagochci zmarl z glodu";
            }

            return status;
        }

    }
}
