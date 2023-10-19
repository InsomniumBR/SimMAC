using Components;
using System;

namespace Buss
{
    public class Bus16 : Bus
    {

        public Bus16(string NameVal) : base(NameVal) { }

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
                if (value.Length != 16)
                    throw new Exception(@"Property cannot be set with Bus\n Requires an 16-Track Bus.");
                else
                {
                    _Tracks = value;
                    ComponentOutput.Process(this, value);
                }
            }
        }
        #endregion

        public Bus16()
        {
            this.Tracks = Track.GetArray(16);
        }
    }
}
