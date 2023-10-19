using Buss;

namespace Components
{
    public class LM : Component
    {
        #region Attributes
        #endregion

        #region Properties
        public Track[] ValuesNZ { get; set; }

        public Track[] ValuesCOND { get; set; }

        public Bus1 MmuxControl { get; set; }
        #endregion

        public override void Process(Component src, Component comp)
        {
        }
        public override void Process(Component src, Component[] comp)
        {
            if (((Bus)src).Name == "MirCOND2LM") ValuesCOND = (Track[])comp;
            if (((Bus)src).Name == "ALU2LM") ValuesNZ = (Track[])comp;

            if (ValuesCOND != null && ValuesNZ != null) CalculateMmuxControl();
        }

        private void CalculateMmuxControl()
        {
            Track[] tOut = Track.GetArray(1);

            // NZ
            Bit N = ValuesNZ[0].Bit;
            Bit Z = ValuesNZ[1].Bit;

            // LR
            Bit L = ValuesCOND[0].Bit;
            Bit R = ValuesCOND[1].Bit;

            tOut[0].Bit.Bin = (R.Bin && N.Bin) || (L.Bin && Z.Bin) || (L.Bin && R.Bin);

            // =
            //(!L.Bin && R.Bin && N.Bin) || (L.Bin && !R.Bin && Z.Bin) || (L.Bin && R.Bin);

            MmuxControl.Tracks = tOut;
        }
    }
}
