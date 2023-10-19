using Buss;
using Components;

namespace Machine.Mir
{
    public class RD : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus1 _BusMBR;
        private Bus1 _BusStack;
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

        public Bus1 BusMBR
        {
            get
            {
                return _BusMBR;
            }

            set
            {
                _BusMBR = value;
            }
        }

        public Bus1 BusStack
        {
            get
            {
                return _BusStack;
            }

            set
            {
                _BusStack = value;
            }
        }
        #endregion

        public RD()
        {
            this.Bits = Track.GetArray(1);
        }

        public override void Process(Component src, Component comp)
        {
        }
        public override void Process(Component src, Component[] comp)
        {
            Bits = (Track[])comp;
            BusMBR.Tracks = Bits;
            BusStack.Tracks = Bits;
        }
    }
}
