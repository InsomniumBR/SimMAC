using Buss;

namespace Components
{
    public class Shifter : Component
    {
        #region Attributes
        #endregion

        #region Properties
        public Bus16 BusRegisters { get; set; }

        public Bus16 BusMBR { get; set; }

        public Track[] Parameters { get; set; }
        #endregion

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            if (((Track[])comp).Length == 16) Shift((Track[])comp);
            else
                Parameters = (Track[])comp;
        }
        /*
                public void Clock()
                {
                    if (Parameters != null) Shift((Track[])comp);
                }
        */
        private void Shift(Track[] Tracks)
        {
            // If one or another only
            if (Parameters[0].Bit.Bin ^ Parameters[1].Bit.Bin)
            {
                // If it was the first one, shift left.
                if (Parameters[0].Bit.Bin)
                {
                    /*
					Track t = Tracks[0];
					for (int i = 0; i < (Tracks.Length - 1); i++)
					{
						Tracks[i] = Tracks[i+1];
					}
					Tracks[Tracks.Length - 1] = t;
					*/

                    /* // AC
					for (int i = 1; i < (Tracks.Length - 1); i++)
					{
						Tracks[i].Bit = Tracks[i+1].Bit;
					}
					Tracks[Tracks.Length - 1].Bit = new Bit(false);
					*/

                    // DC
                    for (int i = 0; i < Tracks.Length - 1; i++)
                    {
                        Tracks[i].Bit = Tracks[i + 1].Bit;
                    }
                    Tracks[Tracks.Length - 1].Bit = new Bit(false);
                }
                else // If it was the second one, shift right.
                {
                    /*
					Track t = Tracks[Tracks.Length - 1];
					for (int i = Tracks.Length; i > 0; i--)
					{
						Tracks[i] = Tracks[i-1];
					}
					Tracks[Tracks.Length - (Tracks.Length -1)] = t;
					*/

                    /* //AC
					for (int i = Tracks.Length; i > 1; i--)
					{
						Tracks[i].Bit = Tracks[i-1].Bit;
					}
					Tracks[1].Bit = new Bit(false);
					*/

                    // DC
                    for (int i = Tracks.Length; i > 1; i--)
                    {
                        Tracks[i].Bit = Tracks[i - 1].Bit;
                    }
                    Tracks[0].Bit = new Bit(false);
                }
            }

            // If both of them came to 1, or neither of them came to 1,
            // the Shifter would have no effect on the output.

            BusMBR.Tracks = Tracks;
            BusRegisters.Tracks = Tracks;

            Parameters = Track.GetArray(2);
        }
    }
}
