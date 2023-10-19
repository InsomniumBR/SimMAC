using Components;
using System;

namespace Buss
{
    public class Bus2 : Bus
    {

        public Bus2(string NameVal) : base(NameVal) { }

        #region Attributes
        private Track[] _Tracks;
        #endregion

        #region Properties
        public override Track[] Tracks
        {
            get
            {
                return _Tracks;
            }

            set
            {
                if (value.Length != 2)
                    throw new Exception(@"Property cannot be set with Bus\n Requires an 2-Track Bus.");
                else
                {
                    _Tracks = value;
                    ComponentOutput.Process(this, value);
                }
            }
        }
        #endregion

        public Bus2()
        {
            this.Tracks = Track.GetArray(2);
        }
    }
}
