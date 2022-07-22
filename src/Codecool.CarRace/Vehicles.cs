using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.CarRace
{
    public abstract class Vehicles
    {
        protected int NormalSpeed { get; set; }
        protected string Name { get; set; }
        protected int ActualSpeed { get; set; }
        public int DistanceTravelled { get; set; }

        protected Vehicles(int normalSpeed)
        {
            Name = GenerateName();
            NormalSpeed = normalSpeed;
        }

        protected abstract string GenerateName();
        public abstract void PrepareForLap(Race race);

        public void MoveForAnHour()
        {
            DistanceTravelled += ActualSpeed * 1;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("{type: ")
                .Append(GetType().Name)
                .Append(", ")
                .Append("name: ")
                .Append(Name)
                .Append(", ")
                .Append("distance travelled: ")
                .Append(DistanceTravelled)
                .Append("}");
            return sb.ToString();
        }
    }


   

}
