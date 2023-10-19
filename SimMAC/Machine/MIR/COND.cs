using Buss;
using Components;

namespace Machine.Mir
{
    public class COND : Component
    {
        #region Attributes
        private Track[] _bVal;
        private Bus2 _BusLM;
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

        public Bus2 BusLM
        {
            get
            {
                return _BusLM;
            }

            set
            {
                _BusLM = value;
            }
        }
        #endregion

        public COND()
        {
            this.Bits = Track.GetArray(2);
        }

        public override void Process(Component src, Component comp)
        {
        }
        public override void Process(Component src, Component[] comp)
        {
            Bits = (Track[])comp;
            BusLM.Tracks = Bits;
        }
    }
}
