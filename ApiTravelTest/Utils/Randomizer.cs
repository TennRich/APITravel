using System;

namespace ApiTravelTest.Utils
{
    public class Randomizer
    {
        public int GetRandomInt()
        {
            var rnd = new Random();
            return rnd.Next(1, 999999);
        }
    }
}
