using Buss;
using Components;

namespace Machine.Mir
{
    public class A : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus4 _BusDecoderA;
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

        public Bus4 BusDecoderA
        {
            get
            {
                return _BusDecoderA;
            }

            set
            {
                _BusDecoderA = value;
            }
        }
        #endregion

        public A()
        {
            this.Bits = Track.GetArray(4);
        }

        public override void Process(Component src, Component comp)
        {
        }
        public override void Process(Component src, Component[] comp)
        {
            Bits = (Track[])comp;
            BusDecoderA.Tracks = Bits;
        }
    }
}
