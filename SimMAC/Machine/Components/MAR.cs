using Buss;

namespace Components
{
    public class MAR : Component
    {
        #region Attributes
        private Track[] _MirMar;
        #endregion

        #region Properties
        public Bus16 BusAddress { get; set; }
        public Track[] Value { get; set; }
        #endregion

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            Track[] t = (Track[])comp;

            if (((Bus)src).Name.Equals("MirMAR2MAR")) _MirMar = t;
            else if (((Bus)src).Name.Equals("LatchB2MAR") && _MirMar[0].Bit.Bin)
            {
                Track[] t2 = Track.GetArray(16);

                for (int i = 4; i < t.Length; i++)
                    t2[i] = t[i];

                Value = t2;
            }
        }

        public void Clock()
        {
            BusAddress.Tracks = Value;
        }
    }
}
