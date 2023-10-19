using Components;

namespace Registers
{
    public class AMask : Register
    {
        public AMask()
        {
            this.Value = Track.GetArray(16);
            for (int i = 4; i < this.Value.Length; i++)
                this.Value[i].Bit = new Bit(true);
        }
    }
}
