using Buss;

namespace Latchs
{
    public class LatchA : Latch
    {
        public Bus16 BusAMUX;

        public void Clock()
        {
            BusAMUX.Tracks = Value;
        }
    }


}
