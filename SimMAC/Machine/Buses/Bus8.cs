using Components;
using System;

namespace Buss
{
    public class Bus8 : Bus
    {
        public Bus8(string NameVal) : base(NameVal) { }

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
                if (value.Length != 8)
                    throw new Exception(@"Property cannot be set with Bus\n Requires an 8-Track Bus.");
                else
                {
                    _Tracks = value;
                    ComponentOutput.Process(this, value);
                }
            }
        }
        #endregion

        public Bus8()
        {
            this.Tracks = Track.GetArray(8);
        }
    }
}
