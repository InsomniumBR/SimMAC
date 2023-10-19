using Buss;

namespace Components
{
    /// <summary>
    /// Summary description for MPC.
    /// </summary>
    public class MPC : Component
    {

        #region Attributes
        Component[] _component;
        #endregion

        #region Properties
        public Bus8 BusControlMemory { get; set; }
        public Bus8 BusIncrementer { get; set; }
        #endregion

        public MPC()
        {
        }

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            _component = comp;
        }

        public void Clock()
        {
            BusControlMemory.Tracks = (Track[])_component;
            BusIncrementer.Tracks = (Track[])_component;
            OnChanged();
        }
    }
}
