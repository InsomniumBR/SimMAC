using Buss;
using Components;

namespace Machine.Mir
{
    public class B : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus4 _BusDecoderB;
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

        public Bus4 BusDecoderB
        {
            get
            {
                return _BusDecoderB;
            }

            set
            {
                _BusDecoderB = value;
            }
        }
        #endregion

        public B()
        {
            this.Bits = Track.GetArray(4);
        }

        public override void Process(Component src, Component comp)
        {
        }
        public override void Process(Component src, Component[] comp)
        {
            Bits = (Track[])comp;
            BusDecoderB.Tracks = Bits;
        }
    }
}
