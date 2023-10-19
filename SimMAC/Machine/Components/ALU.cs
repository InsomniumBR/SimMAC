using Buss;

namespace Components
{
    public class ALU : Component
    {
        #region Attributes
        private Track[] _ValueA;
        private Track[] _ValueB;
        private Track[] _ValueR;
        #endregion

        #region Properties
        public Bus16 BusShifter { get; set; }

        public Track[] Parameters { get; set; }

        // Track 0 - N
        // Track 1 - Z
        public Bus2 BusLM { get; set; }

        public Track[] ValueA
        {
            get
            {
                return _ValueA;
            }

            set
            {
                _ValueA = value;
                if (_ValueA != null && _ValueB != null) Calculate();
            }
        }

        public Track[] ValueB
        {
            get
            {
                return _ValueB;
            }

            set
            {
                _ValueB = value;
                if (_ValueA != null && _ValueB != null) Calculate();
            }
        }

        public Track[] ValueR // Result
        {
            get
            {
                return _ValueR;
            }

            set
            {
                _ValueR = value;
            }
        }

        #endregion

        public ALU()
        {
        }

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            if (((Bus)src).Name == "MirALU2ALU") Parameters = (Track[])comp;
            if (((Bus)src).Name == "Amux2ALU") ValueA = (Track[])comp;
            if (((Bus)src).Name == "LatchB2ALU") ValueB = (Track[])comp;
        }

        public void Calculate()
        {

            if (!Parameters[0].Bit.Bin && !Parameters[1].Bit.Bin)
                Sum();
            else
                if (!Parameters[0].Bit.Bin && Parameters[1].Bit.Bin)
                And();
            else
                if (Parameters[0].Bit.Bin && !Parameters[1].Bit.Bin)
                A();
            else
                if (Parameters[0].Bit.Bin && Parameters[1].Bit.Bin)
                NotA();

            SetNZ();

            BusShifter.Tracks = ValueR;
        }


        #region Sum
        private void Sum()
        {
            bool bPlusOne = false;
            Track[] tOut = Track.GetArray(16);

            // Set Bits
            for (int i = 15; i > -1; i--)
            {
                // (A Xor B) Xor PlusOne
                tOut[i].Bit.Bin = (_ValueA[i].Bit.Bin ^ _ValueB[i].Bit.Bin) ^ bPlusOne;

                // (A == B) && (B == C) retorna normal, senão retorna invertido.
                bPlusOne = ((_ValueA[i].Bit.Bin == _ValueB[i].Bit.Bin) && (_ValueB[i].Bit.Bin == bPlusOne)) ? tOut[i].Bit.Bin : !tOut[i].Bit.Bin;
            }

            ValueR = tOut;

            //if (bPlusOne) throw new Exception("Sobrecarga da ALU");
        }
        #endregion

        #region And
        private void And()
        {
            Track[] tOut = Track.GetArray(16);

            // Set Bits
            for (int i = 15; i > -1; i--)
            {
                // And
                tOut[i].Bit.Bin = _ValueA[i].Bit.Bin && _ValueB[i].Bit.Bin;
            }

            ValueR = tOut;
            //BusShifter.processa(this,tOut);
        }
        #endregion

        #region A
        private void A()
        {
            // A
            ValueR = ValueA;
            //BusShifter.processa(this,ValueA);
        }
        #endregion

        #region NotA
        private void NotA()
        {
            Track[] tOut = Track.GetArray(16);

            // Set Bits
            for (int i = 15; i > -1; i--)
            {
                // Not A
                tOut[i].Bit.Bin = !_ValueA[i].Bit.Bin;
            }

            ValueR = tOut;
            //BusShifter.processa(this,tOut);
        }
        #endregion

        #region SetNZ
        private void SetNZ()
        {
            Track[] tOut = Track.GetArray(2);
            // Set N
            tOut[0].Bit.Bin = ValueR[0].Bit.Bin;
            // Set Z
            tOut[1].Bit.Bin =
                !(ValueR[0].Bit.Bin ||
                  ValueR[1].Bit.Bin ||
                  ValueR[2].Bit.Bin ||
                  ValueR[3].Bit.Bin ||
                  ValueR[4].Bit.Bin ||
                  ValueR[5].Bit.Bin ||
                  ValueR[6].Bit.Bin ||
                  ValueR[7].Bit.Bin ||
                  ValueR[8].Bit.Bin ||
                  ValueR[9].Bit.Bin ||
                  ValueR[10].Bit.Bin ||
                  ValueR[11].Bit.Bin ||
                  ValueR[12].Bit.Bin ||
                  ValueR[13].Bit.Bin ||
                  ValueR[14].Bit.Bin ||
                  ValueR[15].Bit.Bin);

            BusLM.Tracks = tOut;
        }
        #endregion

    }
}