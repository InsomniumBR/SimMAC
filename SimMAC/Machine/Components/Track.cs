using Buss;

namespace Components
{
    public class Track : Component
    {
        #region Attributes
        #endregion

        #region Properties
        public Component ComponentInput { get; set; }

        public Component ComponentOutput { get; set; }

        public Bus ParentBus { get; set; }

        public Bit Bit { get; set; }
        #endregion

        public Track()
        {
            Bit = new Bit();
        }

        public Track(Bus b)
        {
            ParentBus = b;
            Bit = new Bit();
        }

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp) { }

        public static Track[] GetArray(int size)
        {
            Track[] tOut = new Track[size];
            for (int i = 0; i < tOut.Length; i++) tOut[i] = new Track();
            return tOut;
        }
    }
}
