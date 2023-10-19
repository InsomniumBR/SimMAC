using Buss;
using Components;

namespace Machine.Mir
{
    public class MAR : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus1 _BusMAR;
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

        public Bus1 BusMAR
        {
            get
            {
                return _BusMAR;
            }

            set
            {
                _BusMAR = value;
            }
        }
        #endregion

        public MAR()
        {
            this.Bits = Track.GetArray(1);
        }

        public override void Process(Component src, Component comp)
        {
        }
        public override void Process(Component src, Component[] comp)
        {
            Bits = (Track[])comp;
            BusMAR.Tracks = Bits;
        }
    }
}
