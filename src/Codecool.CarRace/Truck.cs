using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecool.CarRace
{
    public class Truck : Vehicles
    {
        private const int NORMAL_SPEED = 100;

        private State _state = State.OPERATIONAL;
        private enum State
        {
            OPERATIONAL,
            BROKEN_DOWN,
        }

        public bool IsBrokenDown => _state != State.OPERATIONAL;

        private const int BREAKDOWN_CHANCE = 5;

        private const int TURNS_NEEDED_TO_FIX_TRUCK = 2;

        private int _breakdownTurnsLeft;

        private State NextState()
        {
            switch (_state)
            {
                case State.OPERATIONAL:
                    if (RandomHelper.EventWithChance(BREAKDOWN_CHANCE))
                    {
                        _breakdownTurnsLeft = TURNS_NEEDED_TO_FIX_TRUCK;
                        return State.BROKEN_DOWN;
                    }
                    break;
                case State.BROKEN_DOWN:
                    if (_breakdownTurnsLeft-- > 0)
                    {
                        return State.BROKEN_DOWN;
                    }
                    break;
            }

            return State.OPERATIONAL;
        }


        public Truck()
            : base(NORMAL_SPEED)
        {
        }
        protected override string GenerateName()
        {
            return RandomHelper.NextInt(1001).ToString();
        }

        public override void PrepareForLap(Race race)
        {
            if (IsBrokenDown)
            {
                ActualSpeed = 0;
            }
            else
            {
                ActualSpeed = NORMAL_SPEED;
            }

            // change state after setting the speed so it becomes active only from the next turn
            _state = NextState();
        }
    }
}
