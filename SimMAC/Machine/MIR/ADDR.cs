using Buss;
using Components;

namespace Machine.Mir
{
    public class ADDR : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus8 _BusMmux;
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


        public Bus8 BusMmux
        {
            get
            {
                return _BusMmux;
            }

            set
            {
                _BusMmux = value;
            }
        }
        #endregion

        public ADDR()
        {
            this.Bits = Track.GetArray(8);
        }

        public override void Process(Component src, Component comp)
        {
        }
        public override void Process(Component src, Component[] comp)
        {
            Bits = (Track[])comp;
            BusMmux.Tracks = Bits;
        }
    }
}
