using Buss;

namespace Components
{

    public class Mmux : Component
    {
        #region Attributes
        Track[] _valInc;
        Track[] _valAddr;
        #endregion

        #region Properties
        public Bus8 BusMPC { get; set; }

        public Bit CtrlMmux { get; set; }
        #endregion

        public Mmux()
        {
            CtrlMmux = new Bit(false);
        }

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {

            if (((Bus)src).Name.Equals("LM2Mmux"))
            {
                CtrlMmux = ((Track[])comp)[0].Bit;
                if (CtrlMmux.Bin)
                    BusMPC.Tracks = _valAddr;
                else
                    BusMPC.Tracks = _valInc;

            }
            else
            {
                if (((Bus)src).Name.Equals("Inc2Mmux"))
                    _valInc = (Track[])comp;
                else if (((Bus)src).Name.Equals("MirAddr2Mmux"))
                    _valAddr = (Track[])comp;
            }
            /*
                        if(CtrlMmux.Bin && ((Bus) src).Name.Equals("MirAddr2Mmux"))
                            BusMPC.Tracks = (Track[])comp;
                        else
                        {
                            if (!CtrlMmux.Bin && ((Bus) src).Name.Equals("Inc2Mmux"))
                                BusMPC.Tracks = (Track[]) comp;
                            else
                            {
                                if (((Bus) src).Name.Equals("LM2Mmux"))
                                    this._bCtrlMmux = ((Track[]) comp)[0].Bit;
                            }
                        }
            */
        }
    }
}
