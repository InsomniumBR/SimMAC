using Buss;

namespace Components
{
    public class MBR : Component
    {
        #region Attributes
        private Track[] _valueShifter;
        #endregion

        #region Properties
        public Bus16 BusAMUX { get; set; }
        public BusBID BusData { get; set; }
        public Track[] MirMBR { get; set; }
        public Track[] RD { get; set; }
        public Track[] WR { get; set; }
        public Track[] ValueStored { get; set; }
        #endregion

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            Track[] t = (Track[])comp;

            if (((Bus)src).Name.Equals("MirMBR2MBR"))
                MirMBR = t;
            else if (((Bus)src).Name.Equals("MirRD2MBR"))
                RD = t;
            else if (((Bus)src).Name.Equals("MirWR2MBR"))
                WR = t;
            else if (((Bus)src).Name.Equals("Shifter2MBR") && MirMBR[0].Bit.Bin)
                _valueShifter = t;
            else if (((Bus)src).Name.Equals("BusData"))
            {
                this.ValueStored = (Track[])comp;
                BusAMUX.Tracks = this.ValueStored;
            }
        }

        public void Clock()
        {
            if (MirMBR[0].Bit.Bin) ValueStored = _valueShifter;
            if (RD[0].Bit.Bin) ValueStored = BusData.Tracks;
            if (WR[0].Bit.Bin) BusData.Process(this, ValueStored);
        }
    }
}
