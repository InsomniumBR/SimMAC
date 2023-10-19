using Buss;
using Components;

namespace Machine.Mir
{
    public class C : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus4 _BusDecoderC;
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

        public Bus4 BusDecoderC
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

        public C()
        {
            this.Bits = Track.GetArray(4);
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
