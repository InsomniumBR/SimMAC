using Components;
using System;

namespace Buss
{
    /// <summary>
    /// Summary description for Bus32.
    /// </summary>
    public class Bus32 : Bus
    {
        public Bus32(string NameVal) : base(NameVal) { }

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
                if (value.Length != 32)
                    throw new Exception(@"Property cannot be set with Bus\n Requires an 32-Track Bus.");
                else
                {
                    _Tracks = value;
                    ComponentOutput.Process(this, value);
                }
            }
        }
        #endregion

        public Bus32()
        {
            this.Tracks = Track.GetArray(32);
        }
    }
}
