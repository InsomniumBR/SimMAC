using Buss;

namespace Latchs
{
    public class LatchB : Latch
    {
        public Bus16 BusMAR;
        public Bus16 BusALU;

        public void Clock()
        {
            BusALU.Tracks = Value;
            BusMAR.Tracks = Value;
        }
    }
}
