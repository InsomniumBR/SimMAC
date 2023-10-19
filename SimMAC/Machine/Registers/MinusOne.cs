namespace Registers
{
    public class MinusOne : Register
    {
        public MinusOne()
        {
            this.Value = Components.Track.GetArray(16);
            for (int i = 0; i < this.Value.Length; i++)
                this.Value[i].Bit.Bin = true;
        }
    }
}
