using Components;

namespace Registers
{
    public class Register : Component
    {
        #region Attributes
        #endregion

        #region Properties
        public Bit ReadC { get; set; }
        public Bit WriteB { get; set; }
        public Bit WriteA { get; set; }
        #endregion

        public Track[] Value;

        public Register()
        {
            Value = Track.GetArray(16);
            ReadC = new Bit();
            WriteB = new Bit();
            WriteA = new Bit();
        }

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp) { }
    }
}
