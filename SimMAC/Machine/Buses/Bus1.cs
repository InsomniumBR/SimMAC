using Components;
using System;

namespace Buss
{
    public class Bus1 : Bus
    {

        public Bus1(string NameVal) : base(NameVal) { }

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
                if (value.Length != 1)
                    throw new Exception(@"Property cannot be set with Bus\n Requires an 1-Track Bus.");
                else
                {
                    _Tracks = value;
                    ComponentOutput.Process(this, value);
                }
            }
        }
        #endregion

        public Bus1()
        {
            this.Tracks = Track.GetArray(1);
        }
    }
}