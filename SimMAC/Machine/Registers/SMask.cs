using Components;

namespace Registers
{
    public class SMask : Register
    {
        public SMask()
        {
            this.Value = Track.GetArray(16);
            for (int i = 8; i < this.Value.Length; i++)
                this.Value[i].Bit = new Bit(true);
        }
    }
}
