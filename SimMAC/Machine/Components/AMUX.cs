using Buss;

namespace Components
{
    public class AMUX : Component
    {
        #region Attributes
        #endregion

        #region Properties
        public Bus16 BusALU { get; set; }

        /// <summary>
        /// Latch A - 0
        /// MBR - 1
        /// </summary>
        public Bit State { get; set; }
        #endregion

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            Track[] Tracks = (Track[])comp;

            if (Tracks.Length == 1)
            {
                this.State = Tracks[0].Bit;
                return;
            }

            if (this.State.Bin)
            {
                if (((Bus)src).Name == "MBR2Amux")
                {
                    BusALU.Tracks = Tracks;
                }
            }
            else
            {
                if (((Bus)src).Name == "LatchA2Amux")
                {
                    BusALU.Tracks = Tracks;
                }
            }
        }
    }
}
