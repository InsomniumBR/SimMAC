using Buss;
using Components;

namespace Machine.Mir
{
    public class ENC : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus1 _BusDecoderC;
        #endregion

        #region Properties
        public Track[] Bits
        {
            get
            {
                return _bVal;
            }

            set
            {
                _bVal = value;
            }
        }

        public Bus1 BusDecoderC
        {
            get
            {
                return _BusDecoderC;
            }

            set
            {
                _BusDecoderC = value;
            }
        }
        #endregion

        public ENC()
        {
            this.Bits = Track.GetArray(1);
        }

        public override void Process(Component src, Component comp)
        {
        }
        public override void Process(Component src, Component[] comp)
        {
            Bits = (Track[])comp;
            BusDecoderC.Tracks = Bits;
        }
    }
}
