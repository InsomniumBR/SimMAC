using Buss;
using Components;

namespace Machine.Mir
{
    public class ALU : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus2 _BusALU;
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

        public Bus2 BusALU
        {
            get
            {
                return _BusALU;
            }

            set
            {
                _BusALU = value;
            }
        }
        #endregion

        public ALU()
        {
            this.Bits = Track.GetArray(2);
        }

        public override void Process(Component src, Component comp)
        {
        }
        public override void Process(Component src, Component[] comp)
        {
            Bits = (Track[])comp;
            BusALU.Tracks = Bits;
        }
    }
}
