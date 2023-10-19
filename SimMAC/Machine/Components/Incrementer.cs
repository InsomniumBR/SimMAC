using Buss;

namespace Components
{
    /// <summary>
    /// Summary description for Incrementador.
    /// </summary>
    public class Incrementer : Component
    {

        #region Attributes
        #endregion

        #region Properties
        public Bus8 BusMmux { get; set; }
        #endregion

        public Incrementer()
        {

        }

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            bool bPlusOne = false;
            Track[] tOut = Track.GetArray(8);

            Track[] tIn = (Track[])comp;

            Track[] tValUm = Track.GetArray(8);

            // Val = 00000001
            tValUm[7].Bit.Bin = true;


            // Set Bits
            for (int i = 7; i > -1; i--)
            {
                // (A Xor B) Xor PlusOne
                tOut[i].Bit.Bin = (tIn[i].Bit.Bin ^ tValUm[i].Bit.Bin) ^ bPlusOne;

                // (A == B) && (B == C) retorna normal, senão retorna invertido.
                bPlusOne = ((tIn[i].Bit.Bin == tValUm[i].Bit.Bin) && (tValUm[i].Bit.Bin == bPlusOne)) ? tOut[i].Bit.Bin : !tOut[i].Bit.Bin;

            }

            BusMmux.Tracks = tOut;
        }
    }
}
