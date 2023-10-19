using Components;
using System;

namespace Buss
{
    public class Bus4 : Bus
    {
        public Bus4(string NameVal) : base(NameVal) { }

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
                if (value.Length != 4)
                    throw new Exception(@"Property cannot be set with Bus\n Requires an 4-Track Bus.");
                else
                {
                    _Tracks = value;
                    ComponentOutput.Process(this, value);
                }
            }
        }
        #endregion

        public Bus4()
        {
            this.Tracks = Track.GetArray(4);
        }
    }
}