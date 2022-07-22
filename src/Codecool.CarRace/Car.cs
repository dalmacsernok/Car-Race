using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecool.CarRace
{
    public class Car : Vehicles
    {
        public Car()
            : base(CalculateNormalSpeed())
        { }

        /// <summary>
        /// The normal speed of the car determined by random.
        /// </summary>
        /// <returns>A value between 80 and 110 inclusive.</returns>
        private static int CalculateNormalSpeed()
        {
            return RandomHelper.NextInt(80, 110 + 1);
        }
        private static readonly string[] POSSIBLE_NAMES =
        {
            "Serpent",
            "Silver",
            "Motion",
            "Guardian",
            "Pyre",
            "Mythic",
            "Patron",
            "Vagabond",
            "Stardust",
            "Vortex"
        };

        private string GetName() => RandomHelper.ChooseOne(POSSIBLE_NAMES);
        protected override string GenerateName()
        {
            return $"{GetName()} {GetName()}";
        }

        protected const int YELLOW_FLAG_SPEED = 75;

        public override void PrepareForLap(Race race)
        {
            if (race.IsThereABrokenTruck)
            {
                ActualSpeed = YELLOW_FLAG_SPEED;
            }
            else
            {
                ActualSpeed = NormalSpeed;
            }
        }

    }
}
