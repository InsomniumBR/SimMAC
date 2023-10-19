using Buss;
using Components;

namespace Machine.Mir
{
    public class MBR : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus1 _BusMBR;
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
        #endregion

        public MBR()
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
        }
    }
}
