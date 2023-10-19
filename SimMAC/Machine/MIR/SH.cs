using Buss;
using Components;

namespace Machine.Mir
{
    public class SH : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus2 _BusShifter;
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

        public Bus2 BusShifter
        {
            get
            {
                return _BusShifter;
            }

            set
            {
                _BusShifter = value;
            }
        }
        #endregion

        public SH()
        {
            this.Bits = Track.GetArray(2);
        }

        public override void Process(Component src, Component comp)
        {
        }
        public override void Process(Component src, Component[] comp)
        {
            Bits = (Track[])comp;
            BusShifter.Tracks = Bits;
        }
    }
}
