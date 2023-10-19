using Components;

namespace Buss
{
    public class Bus : Component
    {

        //public delegate void BusEventHandler (object sender, BusEventArgs args);
        //public event BusEventHandler ValueSet;

        /*
		public virtual void OnValueSet(BusEventArgs args)
		{
			if (ValueSet != null) ValueSet(this,args);
		}
		*/

        public Bus() { }
        public Bus(string NameVal) { this.Name = NameVal; }
        #region Attributes
        private Track[] _Tracks;
        public string Name;
        #endregion

        #region Properties
        public virtual Track[] Tracks
        {
            get
            {
                return _Tracks;
            }
            set
            {
                _Tracks = value;
                ComponentOutput.Process(this, value);
                //OnValueSet(new BusEventArgs(_Tracks));
            }
        }

        public Component ComponentOutput { get; set; }
        #endregion

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp) { }
    }
    /*
        public class BusEventArgs : System.EventArgs {
            public Track[] _Tracks;

            public BusEventArgs(Track[] t)
            {
                _Tracks = t;
            }
        }
    */
}
