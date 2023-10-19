using Buss;
using Components;

namespace Machine.Mir
{
    public class AMUX : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus1 _BusAMUX;
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

        public Bus1 BusAMUX
        {
            get
            {
                return _BusAMUX;
            }

            set
            {
                _BusAMUX = value;
            }
        }
        #endregion

        public AMUX()
        {
            this.Bits = Track.GetArray(1);
        }

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            Bits = ((Track[])comp);
            BusAMUX.Tracks = Bits;
        }
    }
}
