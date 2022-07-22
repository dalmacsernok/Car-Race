using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecool.CarRace
{
    public class Motorcycle : Vehicles
    {
        public const int NORMAL_SPEED = 100;
        public Motorcycle()
            : base(NORMAL_SPEED)
        {
        }
        private static int _motorcycleNumber = 1;

        protected override string GenerateName()
        {
            return "Motorcycle " + _motorcycleNumber++;
        }
        public override void PrepareForLap(Race race)
        {
            ActualSpeed = NORMAL_SPEED;

            if (race.IsRaining)
            {
                int slowDown = RandomHelper.NextInt(5, 50 + 1);
                ActualSpeed -= slowDown;
            }
        }
    }
}
