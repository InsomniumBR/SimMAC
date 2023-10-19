using Components;
using System;

namespace Buss
{
    public class BusBID : Bus
    {
        public BusBID(string NameVal) : base(NameVal) { }

        #region Attributes
        private Track[] _Tracks;
        private Component _Input;
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
                    throw new Exception(@"Property cannot be set with Bus\n Requires an 8-Track Bus.");
                else
                {
                    _Tracks = value;
                    ComponentOutput.Process(this, value);
                }
            }
        }

        public Component ComponentInput
        {
            get
            {
                return _Input;
            }
            set
            {
                _Input = value;
            }
        }
        #endregion

        public override void Process(Component src, Component[] comp)
        {
            // se direção = 1 > esquerda
            // senão direita.
            if (((Component)src).GetType().Name != "MBR")
                ComponentOutput.Process(this, comp);
            else
                ComponentInput.Process(this, comp);
        }
    }
}
