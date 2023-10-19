using Buss;
using Components;

namespace Decoders
{
    public class Decoder : Component
    {
        #region Attributes
        private Track[] _Value;
        private Bus16 _BusRegs;
        #endregion

        #region Properties
        public Track[] Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }
        public Bus16 BusRegs
        {
            get
            {
                return _BusRegs;
            }
            set
            {
                _BusRegs = value;
            }
        }
        #endregion

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            Track[] tIn = (Track[])comp;
            Track[] tOut = Track.GetArray(16);
            tOut[Machine.Machine.BinaryToInt(tIn)].Bit.Bin = true;
            BusRegs.Tracks = tOut;
        }
    }
}
