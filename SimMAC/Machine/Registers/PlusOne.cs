using Components;

namespace Registers
{
    public class PlusOne : Register
    {
        public PlusOne()
        {
            this.Value = Track.GetArray(16);
            this.Value[15].Bit = new Bit(true);
        }
    }
}
