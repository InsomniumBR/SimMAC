using Components;

namespace Decoders
{
    public class DecoderC : Decoder
    {
        private Track[] _ENC;

        public override void Process(Component src, Component[] comp)
        {
            if (src.GetType().Name.Equals("Bus1"))
            {
                // ENableC
                _ENC = ((Track[])comp);
            }
            else
            {
                Value = (Track[])comp;
            }
        }

        public void Clock()
        {
            if (_ENC[0].Bit.Bin)
            {
                Track[] tOut = Track.GetArray(16);
                tOut[(Machine.Machine.BinaryToInt(Value))].Bit.Bin = true;
                BusRegs.Tracks = tOut;
            }
        }

    }
}