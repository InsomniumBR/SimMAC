using Components;

namespace Machine.Mir
{
    public class Mir : Component
    {
        public AMUX AMUX;
        public COND COND;
        public ALU ALU;
        public SH SH;
        public MBR MBR;
        public MAR MAR;
        public RD RD;
        public WR WR;
        public ENC ENC;
        public C C;
        public B B;
        public A A;
        public ADDR ADDR;

        public Track[] Value;

        public Mir()
        {
            AMUX = new AMUX();
            COND = new COND();
            ALU = new ALU();
            SH = new SH();
            MBR = new MBR();
            MAR = new MAR();
            RD = new RD();
            WR = new WR();
            ENC = new ENC();
            C = new C();
            B = new B();
            A = new A();
            ADDR = new ADDR();
        }

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            Value = (Track[])comp;
        }

        public void Clock()
        {
            // Setndo Components da Mir
            AMUX.Process(this, new Track[] { Value[0] });
            COND.Process(this, new Track[] { Value[1], Value[2] });
            ALU.Process(this, new Track[] { Value[3], Value[4] });
            SH.Process(this, new Track[] { Value[5], Value[6] });
            MBR.Process(this, new Track[] { Value[7] });
            MAR.Process(this, new Track[] { Value[8] });
            RD.Process(this, new Track[] { Value[9] });
            WR.Process(this, new Track[] { Value[10] });
            ENC.Process(this, new Track[] { Value[11] });
            C.Process(this, new Track[] { Value[12], Value[13], Value[14], Value[15] });
            B.Process(this, new Track[] { Value[16], Value[17], Value[18], Value[19] });
            A.Process(this, new Track[] { Value[20], Value[21], Value[22], Value[23] });
            ADDR.Process(this, new Track[] {Value[24],Value[25],Value[26],Value[27],
                                                Value[28],Value[29],Value[30],Value[31]});
        }
    }
}
