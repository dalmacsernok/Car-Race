using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecool.CarRace
{
    public class Weather
    {
        
        private const int CHANCE_OF_RAIN = 30;

        public bool IsRaining { get; private set; }
        
        public Weather()
        {
            Randomize();
        }

        public void Randomize()
        {
            IsRaining = RandomHelper.EventWithChance(CHANCE_OF_RAIN);
        }
    }
}
