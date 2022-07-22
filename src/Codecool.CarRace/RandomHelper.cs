using System;
using System.Collections.Generic;

namespace Codecool.CarRace
{
    /*public class Util
    {
        private readonly List<string> _names = new()
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

        public string getCarName()
        {
            Random r = new Random();
            int random = r.Next(0, _names.Count);
            int random2 = r.Next(0, _names.Count);
            return $"{_names[random]} {_names[random2]}";
        }
    }*/
    public class RandomHelper
    {
        /// <summary>
        /// An instance of a pseudorandom number generator shared for all
        /// uses of methods.
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Initializes a new instance of the <see cref="RandomHelper"/> class.
        /// No point in making instances of this class.
        /// </summary>
        private RandomHelper()
        {
        }

        /// <summary>
        /// Generate a random integer from a given range.
        /// </summary>
        /// <param name="upper">upper limit of the range.</param>
        /// <returns>A random number between 0 and an upper bound.</returns>
        public static int NextInt(int upper)
        {
            return _random.Next(upper);
        }

        public static string ChooseOne(string[] possibilities)
        {
            if (possibilities != null && possibilities.Length >= 1)
                return possibilities[_random.Next(possibilities.Length)];

            throw new ArgumentException("Possibilities should be a non-empty array of strings.");
        }

        public static int NextInt(int lower, int upper)
        {
            return _random.Next(lower, upper);
        }

        public static bool EventWithChance(int chance)
        {
            return _random.Next(100) < chance;
        }
    }
}
