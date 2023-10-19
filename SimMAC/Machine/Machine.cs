using Buss;
using Components;
using Decoders;
using Latchs;
using System;
using System.Windows.Forms;

namespace Machine
{
    public class Machine
    {
        #region Attributes
        // TODO : esta Loading primeiro o Form, ele deve Loadr depois
        public Form _frmPrincipal = null;
        public Form _frmMenu = null;

        public SimStack stack = null;
        public MPC mpc = null;
        public Mmux mmux = null;
        public Incrementer inc = null;
        public ControlMemory memCtrl = null;

        public Mir.Mir mir = null;

        public LM lm = null;
        public ALU alu = null;
        public AMUX amux = null;
        public Shifter Shifter = null;
        public MBR mbr = null;
        public MAR mar = null;
        public Registers.Registers regs = null;

        public LatchA latchA = null;
        public LatchB latchB = null;

        public DecoderA DecoderA = null;
        public DecoderB DecoderB = null;
        public DecoderC DecoderC = null;

        public Bus8 bMmux2MPC = null;
        public Bus8 bMPC2Inc = null;
        public Bus8 bMPC2MemCtrl = null;
        public Bus8 bInc2Mmux = null;

        public Bus32 bMemCtrl2Mir = null;

        public Bus1 bMirAmux2Amux = null;
        public Bus2 bMirCOND2LM = null;
        public Bus2 bMirALU2ALU = null;
        public Bus2 bMirSH2Shifter = null;
        public Bus1 bMirMBR2MBR = null;
        public Bus1 bMirMAR2MAR = null;
        public Bus1 bMirRD2MBR = null;
        public Bus1 bMirWR2MBR = null;
        public Bus1 bMirENC2DecoderC = null;
        public Bus4 bMirC2DecoderC = null;
        public Bus4 bMirB2DecoderB = null;
        public Bus4 bMirA2DecoderA = null;
        public Bus8 bMirAddr2Mmux = null;

        public Bus1 bLM2Mmux = null;
        public Bus16 bDecoderC2Regs = null;
        public Bus16 bDecoderB2Regs = null;
        public Bus16 bDecoderA2Regs = null;

        public Bus16 bRegs2BusB = null;
        public Bus16 bRegs2BusA = null;

        public Bus16 bBusC = null;
        public Bus16 bBusB = null;
        public Bus16 bBusA = null;

        public Bus16 bLatchB2ALU = null;
        public Bus16 bLatchB2MAR = null;
        public Bus16 bLatchA2Amux = null;

        public Bus16 bMBR2Amux = null;
        public Bus16 bAmux2ALU = null;

        public Bus2 bALU2LM = null;
        public Bus16 bALU2Shifter = null;
        public Bus16 bShifter2MBR = null;
        public Bus16 bShifter2Regs = null;

        // Memória
        public Bus16 bBusAddress = null;
        public BusBID bBusData = null;
        public Bus1 bMirRD2Stack = null;
        public Bus1 bMirWR2Stack = null;

        #endregion

        #region Properties
        public Form frmPrincipal
        {
            get
            {
                return _frmPrincipal;
            }
            set
            {
                _frmPrincipal = value;
            }
        }
        public Form frmMenu
        {
            get
            {
                return _frmMenu;
            }
            set
            {
                _frmMenu = value;
            }
        }
        #endregion

        public Machine(Form _main, Form _menu)
        {
            frmPrincipal = _main;
            frmMenu = _menu;

            CreateMachine();
            CreateConnections();
        }

        private void CreateMachine()
        {
            // Criando Components
            stack = new SimStack();

            mpc = new MPC();
            mmux = new Mmux();
            inc = new Incrementer();
            memCtrl = new ControlMemory();

            mir = new Mir.Mir();

            lm = new LM();
            alu = new ALU();
            amux = new AMUX();
            Shifter = new Shifter();
            mbr = new MBR();
            mar = new MAR();
            regs = new Registers.Registers();

            latchA = new LatchA();
            latchB = new LatchB();

            DecoderA = new DecoderA();
            DecoderB = new DecoderB();
            DecoderC = new DecoderC();

            // Criando Buss de Ligação
            bMmux2MPC = new Bus8("Mmux2MPC");
            bMPC2Inc = new Bus8("MPC2Inc");
            bMPC2MemCtrl = new Bus8("MPC2MemCtrl");
            bInc2Mmux = new Bus8("Inc2Mmux");

            bMemCtrl2Mir = new Bus32("MemCtrl2Mir");

            bMirAmux2Amux = new Bus1("MirAmux2Amux");
            bMirCOND2LM = new Bus2("MirCOND2LM");
            bMirALU2ALU = new Bus2("MirALU2ALU");
            bMirSH2Shifter = new Bus2("MirSH2Shifter");
            bMirMBR2MBR = new Bus1("MirMBR2MBR");
            bMirMAR2MAR = new Bus1("MirMAR2MAR");
            bMirRD2MBR = new Bus1("MirRD2MBR");
            bMirRD2Stack = new Bus1("MirRD2Stack");
            bMirWR2MBR = new Bus1("MirWR2MBR");
            bMirWR2Stack = new Bus1("MirWR2Stack");
            bMirENC2DecoderC = new Bus1("MirENC2DecoderC");
            bMirC2DecoderC = new Bus4("MirC2DecoderC");
            bMirB2DecoderB = new Bus4("MirB2DecoderB");
            bMirA2DecoderA = new Bus4("MirA2DecoderA");
            bMirAddr2Mmux = new Bus8("MirAddr2Mmux");

            bLM2Mmux = new Bus1("LM2Mmux");

            bDecoderC2Regs = new Bus16("DecoderC2Regs");
            bDecoderB2Regs = new Bus16("DecoderB2Regs");
            bDecoderA2Regs = new Bus16("DecoderA2Regs");

            bRegs2BusB = new Bus16("Regs2BusB");
            bRegs2BusA = new Bus16("Regs2BusA");

            bBusC = new Bus16("BusC2Regs");
            bBusB = new Bus16("BusB2LatchB");
            bBusA = new Bus16("BusA2LatchA");

            bLatchB2ALU = new Bus16("LatchB2ALU");
            bLatchB2MAR = new Bus16("LatchB2MAR");
            bLatchA2Amux = new Bus16("LatchA2Amux");

            bMBR2Amux = new Bus16("MBR2Amux");
            bAmux2ALU = new Bus16("Amux2ALU");

            bALU2LM = new Bus2("ALU2LM");
            bALU2Shifter = new Bus16("ALU2Shifter");
            bShifter2MBR = new Bus16("Shifter2MBR");
            bShifter2Regs = new Bus16("Shifter2Regs");

            bBusData = new BusBID("BusData");
            bBusAddress = new Bus16("BusAddress");
        }

        private void CreateConnections()
        {
            // Criando Mmux - MPC
            mmux.BusMPC = bMmux2MPC;
            bMmux2MPC.ComponentOutput = mpc;

            // Criando MPC - Incrementador
            mpc.BusIncrementer = bMPC2Inc;
            bMPC2Inc.ComponentOutput = inc;

            // Criando Incrementador - Mmux
            inc.BusMmux = bInc2Mmux;
            bInc2Mmux.ComponentOutput = mmux;

            // Criando MPC - MemCtrl
            mpc.BusControlMemory = bMPC2MemCtrl;
            bMPC2MemCtrl.ComponentOutput = memCtrl;

            // Criando MemCtrl - Mir
            memCtrl.BusMir = bMemCtrl2Mir;
            bMemCtrl2Mir.ComponentOutput = mir;

            // Criando Mir.Amux - AMUX
            mir.AMUX.BusAMUX = bMirAmux2Amux;
            bMirAmux2Amux.ComponentOutput = amux;

            // Criando Mir.Cond - LM
            mir.COND.BusLM = bMirCOND2LM;
            bMirCOND2LM.ComponentOutput = lm;

            // Criando Mir.Alu - ALU
            mir.ALU.BusALU = bMirALU2ALU;
            bMirALU2ALU.ComponentOutput = alu;

            // Criando Mir.SH - Shifter
            mir.SH.BusShifter = bMirSH2Shifter;
            bMirSH2Shifter.ComponentOutput = Shifter;

            // Criando Mir.MBR - MBR
            mir.MBR.BusMBR = bMirMBR2MBR;
            bMirMBR2MBR.ComponentOutput = mbr;

            // Criando Mir.MAR - MAR
            mir.MAR.BusMAR = bMirMAR2MAR;
            bMirMAR2MAR.ComponentOutput = mar;

            // Criando Mir.RD - MBR
            mir.RD.BusMBR = bMirRD2MBR;
            bMirRD2MBR.ComponentOutput = mbr;

            // Criando Mir.WR - MBR
            mir.WR.BusMBR = bMirWR2MBR;
            bMirWR2MBR.ComponentOutput = mbr;

            // Criando Mir.ENC - DecoderC
            mir.ENC.BusDecoderC = bMirENC2DecoderC;
            bMirENC2DecoderC.ComponentOutput = DecoderC;

            // Criando Mir.C - DecoderC
            mir.C.BusDecoderC = bMirC2DecoderC;
            bMirC2DecoderC.ComponentOutput = DecoderC;

            // Criando Mir.B - DecoderB
            mir.B.BusDecoderB = bMirB2DecoderB;
            bMirB2DecoderB.ComponentOutput = DecoderB;

            // Criando Mir.A - DecoderA
            mir.A.BusDecoderA = bMirA2DecoderA;
            bMirA2DecoderA.ComponentOutput = DecoderA;

            // Criando Mir.ADDR - Mmux
            mir.ADDR.BusMmux = bMirAddr2Mmux;
            bMirAddr2Mmux.ComponentOutput = mmux;

            // Criando LM - Mmux
            lm.MmuxControl = bLM2Mmux;
            bLM2Mmux.ComponentOutput = mmux;

            // Criando DecoderC - Regs
            DecoderC.BusRegs = bDecoderC2Regs;
            bDecoderC2Regs.ComponentOutput = regs;

            // Criando DecoderB - Regs
            DecoderB.BusRegs = bDecoderB2Regs;
            bDecoderB2Regs.ComponentOutput = regs;

            // Criando DecoderA - Regs
            DecoderA.BusRegs = bDecoderA2Regs;
            bDecoderA2Regs.ComponentOutput = regs;

            // Criando Regs - Bus B
            regs.BusB = bBusB;

            // Criando Regs - Bus A
            regs.BusA = bBusA;

            // Criando BusA - Latch A
            bBusA.ComponentOutput = latchA;

            // Criando BusB - Latch B
            bBusB.ComponentOutput = latchB;

            // Criando Latch A - AMUX
            latchA.BusAMUX = bLatchA2Amux;
            bLatchA2Amux.ComponentOutput = amux;

            // Criando Latch B - ALU
            latchB.BusALU = bLatchB2ALU;
            bLatchB2ALU.ComponentOutput = alu;

            // Criando Latch B - ALU
            latchB.BusMAR = bLatchB2MAR;
            bLatchB2MAR.ComponentOutput = mar;

            // Criando MBR - AMUX
            mbr.BusAMUX = bMBR2Amux;
            bMBR2Amux.ComponentOutput = amux;

            // Criando AMUX - ALU
            amux.BusALU = bAmux2ALU;
            bAmux2ALU.ComponentOutput = alu;

            // Criando ALU - LM
            alu.BusLM = bALU2LM;
            bALU2LM.ComponentOutput = lm;

            // Criando ALU - Shifter
            alu.BusShifter = bALU2Shifter;
            bALU2Shifter.ComponentOutput = Shifter;

            // Criando Shifter - MBR
            Shifter.BusMBR = bShifter2MBR;
            bShifter2MBR.ComponentOutput = mbr;

            // Criando Shifter - Regs
            Shifter.BusRegisters = bBusC;
            bBusC.ComponentOutput = regs;

            // MAR - BusAddress
            mar.BusAddress = bBusAddress;
            bBusAddress.ComponentOutput = stack;

            // MBR - BusData
            mbr.BusData = bBusData;
            bBusData.ComponentOutput = mbr;

            // Criando Mir.RD - Stack
            mir.RD.BusStack = bMirRD2Stack;
            bMirRD2Stack.ComponentOutput = stack;

            // Criando Mir.WR - Stack
            mir.WR.BusStack = bMirWR2Stack;
            bMirWR2Stack.ComponentOutput = stack;

            // Criando Stack - BusAddress
            stack._busAddress = bBusAddress;

            // Criando Stack - BusData
            stack._busData = bBusData;
            bBusData.ComponentInput = stack;
        }

        #region Utils
        public static uint BinaryToInt(Track[] Tracks)
        {
            uint iRet = 0;


            for (uint i = (uint)Tracks.Length; i > 0; i--)
                iRet += Convert.ToUInt32(Convert.ToUInt32(Math.Pow(2, Tracks.Length - i))) *
                    Convert.ToUInt32((Tracks[i - 1].Bit.Bin ? 1 : 0));

            return iRet;
        }

        public unsafe static string TracksToString(Track[] Tracks)
        {
            if (Tracks == null) return "";

            int len = Tracks.Length;
            char[] sRet = new char[len];

            fixed (char* psRet = sRet)
                for (int i = 0; i < len; i++)
                    psRet[i] = Tracks[i].Bit.Bin ? '1' : '0';

            return new string(sRet);
        }
        #endregion

    }

}
