using Buss;
using Components;

namespace Registers
{
    public class Registers : Component
    {
        public PC PC;
        public AC AC;
        public SP SP;
        public IR IR;
        public TIR TIR;
        public Zero Zero;
        public PlusOne MaisUm;
        public MinusOne MenosUm;
        public AMask AMask;
        public SMask SMask;
        public A A;
        public B B;
        public C C;
        public D D;
        public E E;
        public F F;

        public Bus16 BusA;
        public Bus16 BusB;
        public Track[] Value;
        public Register[] Regs;

        public Registers()
        {
            Regs = new Register[16];

            Regs[0] = PC = new PC();
            Regs[1] = AC = new AC();
            Regs[2] = SP = new SP();
            Regs[3] = IR = new IR();
            Regs[4] = TIR = new TIR();
            Regs[5] = Zero = new Zero();
            Regs[6] = MaisUm = new PlusOne();
            Regs[7] = MenosUm = new MinusOne();
            Regs[8] = AMask = new AMask();
            Regs[9] = SMask = new SMask();
            Regs[10] = A = new A();
            Regs[11] = B = new B();
            Regs[12] = C = new C();
            Regs[13] = D = new D();
            Regs[14] = E = new E();
            Regs[15] = F = new F();
        }

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            Track[] tIn = ((Bus)src).Tracks;

            if (((Bus)src).Name.Equals("DecoderC2Regs"))
                for (int i = 0; i < tIn.Length; i++)
                    Regs[i].ReadC = tIn[i].Bit;
            else
            {
                if (((Bus)src).Name.Equals("DecoderB2Regs"))
                {
                    for (int i = 0; i < tIn.Length; i++)
                        Regs[i].WriteB = tIn[i].Bit;
                    //Clock();
                }
                else
                {
                    if (((Bus)src).Name.Equals("DecoderA2Regs"))
                    {
                        for (int i = 0; i < tIn.Length; i++)
                            Regs[i].WriteA = tIn[i].Bit;
                        Clock();
                    }
                    else
                    {
                        if (((Bus)src).Name.Equals("BusC2Regs"))
                            Value = tIn;
                    }
                }
            }

        }

        public void Clock()
        {
            for (int i = 0; i < Regs.Length; i++)
            {
                if (Regs[i].ReadC.Bin)
                {
                    this.Regs[i].Value = Value;
                }
                else
                {
                    if (Regs[i].WriteA.Bin) BusA.Tracks = Regs[i].Value;
                    if (Regs[i].WriteB.Bin) BusB.Tracks = Regs[i].Value;
                }
            }
        }
    }
}
