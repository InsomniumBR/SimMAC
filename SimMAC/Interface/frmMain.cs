using System.Windows.Forms;

namespace Interface
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class frmMain : System.Windows.Forms.Form
    {
        #region Attributes
        public PictureBox picMbr;
        public PictureBox picMar;
        public PictureBox picRegPc;
        public PictureBox picRegAc;
        public PictureBox picRegSp;
        public PictureBox picRegIr;
        public PictureBox picRegTir;
        public PictureBox picRegZero;
        public PictureBox picRegMaisUm;
        public PictureBox picRegMenosUm;
        public PictureBox picRegAmask;
        public PictureBox picRegSmask;
        public PictureBox picRegA;
        public PictureBox picRegB;
        public PictureBox picRegC;
        public PictureBox picRegD;
        public PictureBox picRegE;
        public PictureBox picRegF;
        public PictureBox picDecodC;
        public PictureBox picDecodB;
        public PictureBox picDecodA;
        public PictureBox picLatchA;
        public PictureBox picLatchB;
        public PictureBox picAmux;
        public PictureBox picShifter;
        public PictureBox picLogMicSeq;
        public PictureBox picMmux;
        public PictureBox picMpc;
        public PictureBox picAlu;
        public PictureBox picMirAmux;
        public PictureBox picMirCond;
        public PictureBox picMirAlu;
        public PictureBox picMirSh;
        public PictureBox picMirMbr;
        public PictureBox picMirMar;
        public PictureBox picMirRd;
        public PictureBox picMirWr;
        public PictureBox picMirEnc;
        public PictureBox picMirC;
        public PictureBox picMirB;
        public PictureBox picMirA;
        public PictureBox picMirAddr;
        public PictureBox picMir;
        public PictureBox picMemControle;
        public PictureBox picIncrementador;
        public PictureBox picBAddr2Mmux1;
        public PictureBox picBAddr2Mmux2;
        public PictureBox picBAddr2Mmux3;
        public PictureBox picBMmux2Mpc;
        public PictureBox picBMpc2MemControle;
        public PictureBox picBMemControle2Mir;
        public PictureBox picBIncrem2Mmux2;
        public PictureBox picBIncrem2Mmux3;
        public PictureBox picBIncrem2Mmux1;
        public PictureBox picBMpc2Incrementador;
        public PictureBox picBMirSh2Desloc1;
        public PictureBox picBMirSh2Desloc2;
        public PictureBox picBMirMbr2Mbr3;
        public PictureBox picBMirMbr2Mbr1;
        public PictureBox picBMirMbr2Mbr2;
        public PictureBox picBMirMar2Mar3;
        public PictureBox picBMirMar2Mar4;
        public PictureBox picBMirMar2Mar1;
        public PictureBox picBMirEnc2DecodC2;
        public PictureBox picBMirEnc2DecodC3;
        public PictureBox picBMirC2DecodC1;
        public PictureBox picBMirC2DecodC2;
        public PictureBox picBMirC2DecodC3;
        public PictureBox picBMirB2DecodB1;
        public PictureBox picBMirB2DecodB2;
        public PictureBox picBMirB2DecodB3;
        public PictureBox picBMirA2DecodA3;
        public PictureBox picBMirA2DecodA2;
        public PictureBox picBMirA2DecodA1;
        public PictureBox picBMirMar2Mar2;
        public PictureBox picBMirEnc2DecodC1;
        public PictureBox picBMirEnc2DecodC4;
        public PictureBox picBMirC2DecodC4;
        public PictureBox picBMirB2DecodB4;
        public PictureBox picBMirB2DecodB5;
        public PictureBox picBMirB2DecodB6;
        public PictureBox picBMirA2DecodA4;
        public PictureBox picBMirA2DecodA5;
        public PictureBox picBMirA2DecodA6;
        public PictureBox picBMirRd2Mbr1;
        public PictureBox picBMirWr2Mbr1;
        public PictureBox picBMirRd2Mbr2;
        public PictureBox picBMirRd2Mbr3;
        public PictureBox picBMirWr2Mbr2;
        public PictureBox picBMirWr2Mbr3;
        public PictureBox picBMirCond2Lms1;
        public PictureBox picBMirCond2Lms2;
        public PictureBox picBMirAlu2Alu1;
        public PictureBox picBMirAlu2Alu2;
        public PictureBox picBMirAmux2Amux1;
        public PictureBox picBMirAmux2Amux2;
        public PictureBox picBLms2Mpc1;
        public PictureBox picBLms2Mpc2;
        public PictureBox picBLms2Mpc3;
        public PictureBox picBDesloc2Mbr;
        public PictureBox picBDesloc2Reg2;
        public PictureBox picBDesloc2Reg3;
        public PictureBox picBDesloc2Reg4;
        public PictureBox picBReg2Pc;
        public PictureBox picBReg2Ac;
        public PictureBox picBReg2Sp;
        public PictureBox picBReg2Ir;
        public PictureBox picBReg2Tir;
        public PictureBox picBReg2Zero;
        public PictureBox picBReg2MaisUm;
        public PictureBox picBReg2MenosUm;
        public PictureBox picBReg2Amask;
        public PictureBox picBReg2Smask;
        public PictureBox picBReg2A;
        public PictureBox picBReg2B;
        public PictureBox picBReg2C;
        public PictureBox picBReg2D;
        public PictureBox picBReg2E;
        public PictureBox picBReg2F;
        public PictureBox picBDesloc2Reg1;
        public PictureBox picBLatchA2Alu;
        public PictureBox picBLatchB2Alu;
        public PictureBox picBMbr2Amux4;
        public PictureBox picBMbr2Amux3;
        public PictureBox picBMbr2Amux2;
        public PictureBox picBMbr2Amux1;
        public PictureBox picBLatchB2Mar1;
        public PictureBox picBLatchB2Mar2;
        public PictureBox picBLatchB2Mar3;
        public PictureBox picBAmux2Alu;
        public PictureBox picBAlu2Shifter;
        public PictureBox picBReg2Latch;
        public PictureBox picBReg2LatchA1;
        public PictureBox picBReg2LatchA2;
        public PictureBox picBReg2LatchB1;
        public PictureBox picBReg2LatchB2;
        public PictureBox picBPc2Latch;
        public PictureBox picBAc2Latch;
        public PictureBox picBSp2Latch;
        public PictureBox picBIr2Latch;
        public PictureBox picBTir2Latch;
        public PictureBox picBZero2Latch;
        public PictureBox picBMaisUm2Latch;
        public PictureBox picBMenosUm2Latch;
        public PictureBox picBAmask2Latch;
        public PictureBox picBSmask2Latch;
        public PictureBox picBA2Latch;
        public PictureBox picBB2Latch;
        public PictureBox picBC2Latch;
        public PictureBox picBD2Latch;
        public PictureBox picBE2Latch;
        public PictureBox picBF2Latch;
        public PictureBox picBDecodC2Reg1;
        public PictureBox picBDecodB2Reg1;
        public PictureBox picBDecodA2Reg1;
        public PictureBox picBDecoders2Reg1;
        public PictureBox picBDecoders2Reg2;
        public PictureBox picBDecoders2Reg3;
        public PictureBox picBDecoders2Reg4;
        public PictureBox picBDecoders2Reg5;
        public PictureBox picBAluN2LMS;
        public PictureBox picBAluZ2LMS;
        private Machine.Machine _machine;
        #endregion

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmMain(Machine.Machine myMachine)
        {
            //
            // Required for Windows Form Designer support
            //
            _machine = myMachine;
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
            this.picMmux = new VisualComponents.Mmux(_machine.mmux);
            this.picMpc = new VisualComponents.MPC(_machine.mpc);
            this.picIncrementador = new VisualComponents.Incrementer(_machine.inc);
            this.picMbr = new System.Windows.Forms.PictureBox();
            this.picMar = new System.Windows.Forms.PictureBox();
            this.picRegPc = new System.Windows.Forms.PictureBox();
            this.picRegAc = new System.Windows.Forms.PictureBox();
            this.picRegSp = new System.Windows.Forms.PictureBox();
            this.picRegIr = new System.Windows.Forms.PictureBox();
            this.picRegTir = new System.Windows.Forms.PictureBox();
            this.picRegZero = new System.Windows.Forms.PictureBox();
            this.picRegMaisUm = new System.Windows.Forms.PictureBox();
            this.picRegMenosUm = new System.Windows.Forms.PictureBox();
            this.picRegAmask = new System.Windows.Forms.PictureBox();
            this.picRegSmask = new System.Windows.Forms.PictureBox();
            this.picRegA = new System.Windows.Forms.PictureBox();
            this.picRegB = new System.Windows.Forms.PictureBox();
            this.picRegC = new System.Windows.Forms.PictureBox();
            this.picRegD = new System.Windows.Forms.PictureBox();
            this.picRegE = new System.Windows.Forms.PictureBox();
            this.picRegF = new System.Windows.Forms.PictureBox();
            this.picDecodC = new System.Windows.Forms.PictureBox();
            this.picDecodB = new System.Windows.Forms.PictureBox();
            this.picDecodA = new System.Windows.Forms.PictureBox();
            this.picLatchA = new System.Windows.Forms.PictureBox();
            this.picLatchB = new System.Windows.Forms.PictureBox();
            this.picAmux = new System.Windows.Forms.PictureBox();
            this.picShifter = new System.Windows.Forms.PictureBox();
            this.picLogMicSeq = new System.Windows.Forms.PictureBox();
            this.picAlu = new System.Windows.Forms.PictureBox();
            this.picBReg2Latch = new System.Windows.Forms.PictureBox();
            this.picBDesloc2Mbr = new System.Windows.Forms.PictureBox();
            this.picBReg2LatchA1 = new System.Windows.Forms.PictureBox();
            this.picBReg2LatchA2 = new System.Windows.Forms.PictureBox();
            this.picBReg2LatchB1 = new System.Windows.Forms.PictureBox();
            this.picBReg2LatchB2 = new System.Windows.Forms.PictureBox();
            this.picBLatchA2Alu = new System.Windows.Forms.PictureBox();
            this.picBLatchB2Alu = new System.Windows.Forms.PictureBox();
            this.picBMbr2Amux4 = new System.Windows.Forms.PictureBox();
            this.picBMbr2Amux3 = new System.Windows.Forms.PictureBox();
            this.picBMbr2Amux2 = new System.Windows.Forms.PictureBox();
            this.picBMbr2Amux1 = new System.Windows.Forms.PictureBox();
            this.picBLatchB2Mar1 = new System.Windows.Forms.PictureBox();
            this.picBLatchB2Mar2 = new System.Windows.Forms.PictureBox();
            this.picBLatchB2Mar3 = new System.Windows.Forms.PictureBox();
            this.picBPc2Latch = new System.Windows.Forms.PictureBox();
            this.picBAc2Latch = new System.Windows.Forms.PictureBox();
            this.picBSp2Latch = new System.Windows.Forms.PictureBox();
            this.picBIr2Latch = new System.Windows.Forms.PictureBox();
            this.picBTir2Latch = new System.Windows.Forms.PictureBox();
            this.picBZero2Latch = new System.Windows.Forms.PictureBox();
            this.picBMaisUm2Latch = new System.Windows.Forms.PictureBox();
            this.picBMenosUm2Latch = new System.Windows.Forms.PictureBox();
            this.picBAmask2Latch = new System.Windows.Forms.PictureBox();
            this.picBSmask2Latch = new System.Windows.Forms.PictureBox();
            this.picBA2Latch = new System.Windows.Forms.PictureBox();
            this.picBB2Latch = new System.Windows.Forms.PictureBox();
            this.picBC2Latch = new System.Windows.Forms.PictureBox();
            this.picBD2Latch = new System.Windows.Forms.PictureBox();
            this.picBE2Latch = new System.Windows.Forms.PictureBox();
            this.picBF2Latch = new System.Windows.Forms.PictureBox();
            this.picMirAmux = new System.Windows.Forms.PictureBox();
            this.picMirCond = new System.Windows.Forms.PictureBox();
            this.picMirAlu = new System.Windows.Forms.PictureBox();
            this.picMirSh = new System.Windows.Forms.PictureBox();
            this.picMirMbr = new System.Windows.Forms.PictureBox();
            this.picMirMar = new System.Windows.Forms.PictureBox();
            this.picMirRd = new System.Windows.Forms.PictureBox();
            this.picMirWr = new System.Windows.Forms.PictureBox();
            this.picMirEnc = new System.Windows.Forms.PictureBox();
            this.picMirC = new System.Windows.Forms.PictureBox();
            this.picMirB = new System.Windows.Forms.PictureBox();
            this.picMirA = new System.Windows.Forms.PictureBox();
            this.picMirAddr = new System.Windows.Forms.PictureBox();
            this.picBDecodC2Reg1 = new System.Windows.Forms.PictureBox();
            this.picBDecodB2Reg1 = new System.Windows.Forms.PictureBox();
            this.picBDecodA2Reg1 = new System.Windows.Forms.PictureBox();
            this.picBMirAmux2Amux1 = new System.Windows.Forms.PictureBox();
            this.picBMirAmux2Amux2 = new System.Windows.Forms.PictureBox();
            this.picBMirCond2Lms1 = new System.Windows.Forms.PictureBox();
            this.picBMirCond2Lms2 = new System.Windows.Forms.PictureBox();
            this.picBMirAlu2Alu1 = new System.Windows.Forms.PictureBox();
            this.picBMirAlu2Alu2 = new System.Windows.Forms.PictureBox();
            this.picBAluN2LMS = new System.Windows.Forms.PictureBox();
            this.picBAluZ2LMS = new System.Windows.Forms.PictureBox();
            this.picBMirSh2Desloc1 = new System.Windows.Forms.PictureBox();
            this.picBMirSh2Desloc2 = new System.Windows.Forms.PictureBox();
            this.picBMirMbr2Mbr3 = new System.Windows.Forms.PictureBox();
            this.picBMirMbr2Mbr1 = new System.Windows.Forms.PictureBox();
            this.picBMirMbr2Mbr2 = new System.Windows.Forms.PictureBox();
            this.picBMirMar2Mar3 = new System.Windows.Forms.PictureBox();
            this.picBMirMar2Mar4 = new System.Windows.Forms.PictureBox();
            this.picBAddr2Mmux1 = new System.Windows.Forms.PictureBox();
            this.picBAddr2Mmux2 = new System.Windows.Forms.PictureBox();
            this.picBAddr2Mmux3 = new System.Windows.Forms.PictureBox();
            this.picBMmux2Mpc = new System.Windows.Forms.PictureBox();
            this.picBMirMar2Mar1 = new System.Windows.Forms.PictureBox();
            this.picBMirEnc2DecodC2 = new System.Windows.Forms.PictureBox();
            this.picBMirEnc2DecodC3 = new System.Windows.Forms.PictureBox();
            this.picBMirEnc2DecodC4 = new System.Windows.Forms.PictureBox();
            this.picBMirC2DecodC1 = new System.Windows.Forms.PictureBox();
            this.picBMirC2DecodC2 = new System.Windows.Forms.PictureBox();
            this.picBMirC2DecodC3 = new System.Windows.Forms.PictureBox();
            this.picBMirC2DecodC4 = new System.Windows.Forms.PictureBox();
            this.picBMirB2DecodB1 = new System.Windows.Forms.PictureBox();
            this.picBMirB2DecodB2 = new System.Windows.Forms.PictureBox();
            this.picBMirB2DecodB3 = new System.Windows.Forms.PictureBox();
            this.picBMirB2DecodB4 = new System.Windows.Forms.PictureBox();
            this.picBMirB2DecodB5 = new System.Windows.Forms.PictureBox();
            this.picBMirB2DecodB6 = new System.Windows.Forms.PictureBox();
            this.picBMirA2DecodA4 = new System.Windows.Forms.PictureBox();
            this.picBMirA2DecodA5 = new System.Windows.Forms.PictureBox();
            this.picBMirA2DecodA6 = new System.Windows.Forms.PictureBox();
            this.picBMirA2DecodA3 = new System.Windows.Forms.PictureBox();
            this.picBMirA2DecodA2 = new System.Windows.Forms.PictureBox();
            this.picBMirA2DecodA1 = new System.Windows.Forms.PictureBox();
            this.picBMirMar2Mar2 = new System.Windows.Forms.PictureBox();
            this.picBMirEnc2DecodC1 = new System.Windows.Forms.PictureBox();
            this.picBMirRd2Mbr1 = new System.Windows.Forms.PictureBox();
            this.picBMirWr2Mbr1 = new System.Windows.Forms.PictureBox();
            this.picBMirRd2Mbr2 = new System.Windows.Forms.PictureBox();
            this.picBMirRd2Mbr3 = new System.Windows.Forms.PictureBox();
            this.picBMirWr2Mbr2 = new System.Windows.Forms.PictureBox();
            this.picBMirWr2Mbr3 = new System.Windows.Forms.PictureBox();
            this.picBMpc2MemControle = new System.Windows.Forms.PictureBox();
            this.picMemControle = new System.Windows.Forms.PictureBox();
            this.picBIncrem2Mmux2 = new System.Windows.Forms.PictureBox();
            this.picBIncrem2Mmux3 = new System.Windows.Forms.PictureBox();
            this.picBIncrem2Mmux1 = new System.Windows.Forms.PictureBox();
            this.picBMpc2Incrementador = new System.Windows.Forms.PictureBox();
            this.picBMemControle2Mir = new System.Windows.Forms.PictureBox();
            this.picBAmux2Alu = new System.Windows.Forms.PictureBox();
            this.picBLms2Mpc1 = new System.Windows.Forms.PictureBox();
            this.picBLms2Mpc2 = new System.Windows.Forms.PictureBox();
            this.picBLms2Mpc3 = new System.Windows.Forms.PictureBox();
            this.picBDesloc2Reg2 = new System.Windows.Forms.PictureBox();
            this.picBDesloc2Reg3 = new System.Windows.Forms.PictureBox();
            this.picBDesloc2Reg4 = new System.Windows.Forms.PictureBox();
            this.picBReg2Pc = new System.Windows.Forms.PictureBox();
            this.picBDecoders2Reg1 = new System.Windows.Forms.PictureBox();
            this.picBDecoders2Reg2 = new System.Windows.Forms.PictureBox();
            this.picBDecoders2Reg3 = new System.Windows.Forms.PictureBox();
            this.picBDecoders2Reg4 = new System.Windows.Forms.PictureBox();
            this.picBDecoders2Reg5 = new System.Windows.Forms.PictureBox();
            this.picBReg2Ac = new System.Windows.Forms.PictureBox();
            this.picBReg2Sp = new System.Windows.Forms.PictureBox();
            this.picBReg2Ir = new System.Windows.Forms.PictureBox();
            this.picBReg2Tir = new System.Windows.Forms.PictureBox();
            this.picBReg2Zero = new System.Windows.Forms.PictureBox();
            this.picBReg2MaisUm = new System.Windows.Forms.PictureBox();
            this.picBReg2MenosUm = new System.Windows.Forms.PictureBox();
            this.picBReg2Amask = new System.Windows.Forms.PictureBox();
            this.picBReg2Smask = new System.Windows.Forms.PictureBox();
            this.picBReg2A = new System.Windows.Forms.PictureBox();
            this.picBReg2B = new System.Windows.Forms.PictureBox();
            this.picBReg2C = new System.Windows.Forms.PictureBox();
            this.picBReg2D = new System.Windows.Forms.PictureBox();
            this.picBReg2E = new System.Windows.Forms.PictureBox();
            this.picBReg2F = new System.Windows.Forms.PictureBox();
            this.picBDesloc2Reg1 = new System.Windows.Forms.PictureBox();
            this.picBAlu2Shifter = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // picIncrementador
            // 
            this.picIncrementador.Image = ((System.Drawing.Image)(resources.GetObject("picIncrementador.Image")));
            this.picIncrementador.Location = new System.Drawing.Point(424, 130);
            this.picIncrementador.Name = "picIncrementador";
            this.picIncrementador.Size = new System.Drawing.Size(64, 32);
            this.picIncrementador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIncrementador.TabIndex = 135;
            this.picIncrementador.TabStop = false;
            // 
            // picMmux
            // 
            this.picMmux.Image = ((System.Drawing.Image)(resources.GetObject("picMmux.Image")));
            this.picMmux.Location = new System.Drawing.Point(536, 90);
            this.picMmux.Name = "picMmux";
            this.picMmux.Size = new System.Drawing.Size(56, 24);
            this.picMmux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMmux.TabIndex = 27;
            this.picMmux.TabStop = false;
            // 
            // picMpc
            // 
            this.picMpc.Image = ((System.Drawing.Image)(resources.GetObject("picMpc.Image")));
            this.picMpc.Location = new System.Drawing.Point(536, 130);
            this.picMpc.Name = "picMpc";
            this.picMpc.Size = new System.Drawing.Size(56, 24);
            this.picMpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMpc.TabIndex = 28;
            this.picMpc.TabStop = false;
            // 
            // picMbr
            // 
            this.picMbr.Image = ((System.Drawing.Image)(resources.GetObject("picMbr.Image")));
            this.picMbr.Location = new System.Drawing.Point(88, 498);
            this.picMbr.Name = "picMbr";
            this.picMbr.Size = new System.Drawing.Size(56, 24);
            this.picMbr.TabIndex = 0;
            this.picMbr.TabStop = false;
            // 
            // picMar
            // 
            this.picMar.Image = ((System.Drawing.Image)(resources.GetObject("picMar.Image")));
            this.picMar.Location = new System.Drawing.Point(88, 434);
            this.picMar.Name = "picMar";
            this.picMar.Size = new System.Drawing.Size(56, 24);
            this.picMar.TabIndex = 1;
            this.picMar.TabStop = false;
            // 
            // picRegPc
            // 
            this.picRegPc.Image = ((System.Drawing.Image)(resources.GetObject("picRegPc.Image")));
            this.picRegPc.Location = new System.Drawing.Point(120, 18);
            this.picRegPc.Name = "picRegPc";
            this.picRegPc.Size = new System.Drawing.Size(48, 24);
            this.picRegPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegPc.TabIndex = 3;
            this.picRegPc.TabStop = false;
            // 
            // picRegAc
            // 
            this.picRegAc.Image = ((System.Drawing.Image)(resources.GetObject("picRegAc.Image")));
            this.picRegAc.Location = new System.Drawing.Point(120, 42);
            this.picRegAc.Name = "picRegAc";
            this.picRegAc.Size = new System.Drawing.Size(48, 24);
            this.picRegAc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegAc.TabIndex = 4;
            this.picRegAc.TabStop = false;
            // 
            // picRegSp
            // 
            this.picRegSp.Image = ((System.Drawing.Image)(resources.GetObject("picRegSp.Image")));
            this.picRegSp.Location = new System.Drawing.Point(120, 66);
            this.picRegSp.Name = "picRegSp";
            this.picRegSp.Size = new System.Drawing.Size(48, 24);
            this.picRegSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegSp.TabIndex = 5;
            this.picRegSp.TabStop = false;
            // 
            // picRegIr
            // 
            this.picRegIr.Image = ((System.Drawing.Image)(resources.GetObject("picRegIr.Image")));
            this.picRegIr.Location = new System.Drawing.Point(120, 90);
            this.picRegIr.Name = "picRegIr";
            this.picRegIr.Size = new System.Drawing.Size(48, 24);
            this.picRegIr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegIr.TabIndex = 6;
            this.picRegIr.TabStop = false;
            // 
            // picRegTir
            // 
            this.picRegTir.Image = ((System.Drawing.Image)(resources.GetObject("picRegTir.Image")));
            this.picRegTir.Location = new System.Drawing.Point(120, 114);
            this.picRegTir.Name = "picRegTir";
            this.picRegTir.Size = new System.Drawing.Size(48, 24);
            this.picRegTir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegTir.TabIndex = 7;
            this.picRegTir.TabStop = false;
            // 
            // picRegZero
            // 
            this.picRegZero.Image = ((System.Drawing.Image)(resources.GetObject("picRegZero.Image")));
            this.picRegZero.Location = new System.Drawing.Point(120, 138);
            this.picRegZero.Name = "picRegZero";
            this.picRegZero.Size = new System.Drawing.Size(48, 24);
            this.picRegZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegZero.TabIndex = 8;
            this.picRegZero.TabStop = false;
            // 
            // picRegMaisUm
            // 
            this.picRegMaisUm.Image = ((System.Drawing.Image)(resources.GetObject("picRegMaisUm.Image")));
            this.picRegMaisUm.Location = new System.Drawing.Point(120, 162);
            this.picRegMaisUm.Name = "picRegMaisUm";
            this.picRegMaisUm.Size = new System.Drawing.Size(48, 24);
            this.picRegMaisUm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegMaisUm.TabIndex = 9;
            this.picRegMaisUm.TabStop = false;
            // 
            // picRegMenosUm
            // 
            this.picRegMenosUm.Image = ((System.Drawing.Image)(resources.GetObject("picRegMenosUm.Image")));
            this.picRegMenosUm.Location = new System.Drawing.Point(120, 186);
            this.picRegMenosUm.Name = "picRegMenosUm";
            this.picRegMenosUm.Size = new System.Drawing.Size(48, 24);
            this.picRegMenosUm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegMenosUm.TabIndex = 10;
            this.picRegMenosUm.TabStop = false;
            // 
            // picRegAmask
            // 
            this.picRegAmask.Image = ((System.Drawing.Image)(resources.GetObject("picRegAmask.Image")));
            this.picRegAmask.Location = new System.Drawing.Point(120, 210);
            this.picRegAmask.Name = "picRegAmask";
            this.picRegAmask.Size = new System.Drawing.Size(48, 24);
            this.picRegAmask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegAmask.TabIndex = 11;
            this.picRegAmask.TabStop = false;
            // 
            // picRegSmask
            // 
            this.picRegSmask.Image = ((System.Drawing.Image)(resources.GetObject("picRegSmask.Image")));
            this.picRegSmask.Location = new System.Drawing.Point(120, 234);
            this.picRegSmask.Name = "picRegSmask";
            this.picRegSmask.Size = new System.Drawing.Size(48, 24);
            this.picRegSmask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegSmask.TabIndex = 12;
            this.picRegSmask.TabStop = false;
            // 
            // picRegA
            // 
            this.picRegA.Image = ((System.Drawing.Image)(resources.GetObject("picRegA.Image")));
            this.picRegA.Location = new System.Drawing.Point(120, 258);
            this.picRegA.Name = "picRegA";
            this.picRegA.Size = new System.Drawing.Size(48, 24);
            this.picRegA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegA.TabIndex = 13;
            this.picRegA.TabStop = false;
            // 
            // picRegB
            // 
            this.picRegB.Image = ((System.Drawing.Image)(resources.GetObject("picRegB.Image")));
            this.picRegB.Location = new System.Drawing.Point(120, 282);
            this.picRegB.Name = "picRegB";
            this.picRegB.Size = new System.Drawing.Size(48, 24);
            this.picRegB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegB.TabIndex = 14;
            this.picRegB.TabStop = false;
            // 
            // picRegC
            // 
            this.picRegC.Image = ((System.Drawing.Image)(resources.GetObject("picRegC.Image")));
            this.picRegC.Location = new System.Drawing.Point(120, 306);
            this.picRegC.Name = "picRegC";
            this.picRegC.Size = new System.Drawing.Size(48, 24);
            this.picRegC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegC.TabIndex = 15;
            this.picRegC.TabStop = false;
            // 
            // picRegD
            // 
            this.picRegD.Image = ((System.Drawing.Image)(resources.GetObject("picRegD.Image")));
            this.picRegD.Location = new System.Drawing.Point(120, 330);
            this.picRegD.Name = "picRegD";
            this.picRegD.Size = new System.Drawing.Size(48, 24);
            this.picRegD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegD.TabIndex = 16;
            this.picRegD.TabStop = false;
            // 
            // picRegE
            // 
            this.picRegE.Image = ((System.Drawing.Image)(resources.GetObject("picRegE.Image")));
            this.picRegE.Location = new System.Drawing.Point(120, 354);
            this.picRegE.Name = "picRegE";
            this.picRegE.Size = new System.Drawing.Size(48, 24);
            this.picRegE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegE.TabIndex = 17;
            this.picRegE.TabStop = false;
            // 
            // picRegF
            // 
            this.picRegF.Image = ((System.Drawing.Image)(resources.GetObject("picRegF.Image")));
            this.picRegF.Location = new System.Drawing.Point(120, 378);
            this.picRegF.Name = "picRegF";
            this.picRegF.Size = new System.Drawing.Size(48, 24);
            this.picRegF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegF.TabIndex = 18;
            this.picRegF.TabStop = false;
            // 
            // picDecodC
            // 
            this.picDecodC.Image = ((System.Drawing.Image)(resources.GetObject("picDecodC.Image")));
            this.picDecodC.Location = new System.Drawing.Point(328, 18);
            this.picDecodC.Name = "picDecodC";
            this.picDecodC.Size = new System.Drawing.Size(48, 32);
            this.picDecodC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDecodC.TabIndex = 19;
            this.picDecodC.TabStop = false;
            // 
            // picDecodB
            // 
            this.picDecodB.Image = ((System.Drawing.Image)(resources.GetObject("picDecodB.Image")));
            this.picDecodB.Location = new System.Drawing.Point(328, 50);
            this.picDecodB.Name = "picDecodB";
            this.picDecodB.Size = new System.Drawing.Size(48, 32);
            this.picDecodB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDecodB.TabIndex = 20;
            this.picDecodB.TabStop = false;
            // 
            // picDecodA
            // 
            this.picDecodA.Image = ((System.Drawing.Image)(resources.GetObject("picDecodA.Image")));
            this.picDecodA.Location = new System.Drawing.Point(328, 82);
            this.picDecodA.Name = "picDecodA";
            this.picDecodA.Size = new System.Drawing.Size(48, 32);
            this.picDecodA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDecodA.TabIndex = 21;
            this.picDecodA.TabStop = false;
            // 
            // picLatchA
            // 
            this.picLatchA.Image = ((System.Drawing.Image)(resources.GetObject("picLatchA.Image")));
            this.picLatchA.Location = new System.Drawing.Point(256, 258);
            this.picLatchA.Name = "picLatchA";
            this.picLatchA.Size = new System.Drawing.Size(56, 24);
            this.picLatchA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLatchA.TabIndex = 22;
            this.picLatchA.TabStop = false;
            // 
            // picLatchB
            // 
            this.picLatchB.Image = ((System.Drawing.Image)(resources.GetObject("picLatchB.Image")));
            this.picLatchB.Location = new System.Drawing.Point(336, 258);
            this.picLatchB.Name = "picLatchB";
            this.picLatchB.Size = new System.Drawing.Size(56, 24);
            this.picLatchB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLatchB.TabIndex = 23;
            this.picLatchB.TabStop = false;
            // 
            // picAmux
            // 
            this.picAmux.Image = ((System.Drawing.Image)(resources.GetObject("picAmux.Image")));
            this.picAmux.Location = new System.Drawing.Point(256, 338);
            this.picAmux.Name = "picAmux";
            this.picAmux.Size = new System.Drawing.Size(56, 24);
            this.picAmux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmux.TabIndex = 24;
            this.picAmux.TabStop = false;
            // 
            // picShifter
            // 
            this.picShifter.Image = ((System.Drawing.Image)(resources.GetObject("picShifter.Image")));
            this.picShifter.Location = new System.Drawing.Point(296, 498);
            this.picShifter.Name = "picShifter";
            this.picShifter.Size = new System.Drawing.Size(56, 32);
            this.picShifter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShifter.TabIndex = 25;
            this.picShifter.TabStop = false;
            // 
            // picLogMicSeq
            // 
            this.picLogMicSeq.Image = ((System.Drawing.Image)(resources.GetObject("picLogMicSeq.Image")));
            this.picLogMicSeq.Location = new System.Drawing.Point(440, 410);
            this.picLogMicSeq.Name = "picLogMicSeq";
            this.picLogMicSeq.Size = new System.Drawing.Size(56, 40);
            this.picLogMicSeq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogMicSeq.TabIndex = 26;
            this.picLogMicSeq.TabStop = false;
            // 
            // picAlu
            // 
            this.picAlu.Image = ((System.Drawing.Image)(resources.GetObject("picAlu.Image")));
            this.picAlu.Location = new System.Drawing.Point(256, 394);
            this.picAlu.Name = "picAlu";
            this.picAlu.Size = new System.Drawing.Size(144, 72);
            this.picAlu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlu.TabIndex = 29;
            this.picAlu.TabStop = false;
            // 
            // picBReg2Latch
            // 
            this.picBReg2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBReg2Latch.Location = new System.Drawing.Point(176, 26);
            this.picBReg2Latch.Name = "picBReg2Latch";
            this.picBReg2Latch.Size = new System.Drawing.Size(10, 366);
            this.picBReg2Latch.TabIndex = 31;
            this.picBReg2Latch.TabStop = false;
            // 
            // picBDesloc2Mbr
            // 
            this.picBDesloc2Mbr.BackColor = System.Drawing.Color.Teal;
            this.picBDesloc2Mbr.Location = new System.Drawing.Point(144, 510);
            this.picBDesloc2Mbr.Name = "picBDesloc2Mbr";
            this.picBDesloc2Mbr.Size = new System.Drawing.Size(144, 10);
            this.picBDesloc2Mbr.TabIndex = 32;
            this.picBDesloc2Mbr.TabStop = false;
            // 
            // picBReg2LatchA1
            // 
            this.picBReg2LatchA1.BackColor = System.Drawing.Color.Teal;
            this.picBReg2LatchA1.Location = new System.Drawing.Point(184, 144);
            this.picBReg2LatchA1.Name = "picBReg2LatchA1";
            this.picBReg2LatchA1.Size = new System.Drawing.Size(98, 10);
            this.picBReg2LatchA1.TabIndex = 34;
            this.picBReg2LatchA1.TabStop = false;
            // 
            // picBReg2LatchA2
            // 
            this.picBReg2LatchA2.BackColor = System.Drawing.Color.Teal;
            this.picBReg2LatchA2.Location = new System.Drawing.Point(272, 146);
            this.picBReg2LatchA2.Name = "picBReg2LatchA2";
            this.picBReg2LatchA2.Size = new System.Drawing.Size(10, 112);
            this.picBReg2LatchA2.TabIndex = 35;
            this.picBReg2LatchA2.TabStop = false;
            // 
            // picBReg2LatchB1
            // 
            this.picBReg2LatchB1.BackColor = System.Drawing.Color.Teal;
            this.picBReg2LatchB1.Location = new System.Drawing.Point(184, 186);
            this.picBReg2LatchB1.Name = "picBReg2LatchB1";
            this.picBReg2LatchB1.Size = new System.Drawing.Size(176, 10);
            this.picBReg2LatchB1.TabIndex = 36;
            this.picBReg2LatchB1.TabStop = false;
            // 
            // picBReg2LatchB2
            // 
            this.picBReg2LatchB2.BackColor = System.Drawing.Color.Teal;
            this.picBReg2LatchB2.Location = new System.Drawing.Point(352, 186);
            this.picBReg2LatchB2.Name = "picBReg2LatchB2";
            this.picBReg2LatchB2.Size = new System.Drawing.Size(10, 72);
            this.picBReg2LatchB2.TabIndex = 37;
            this.picBReg2LatchB2.TabStop = false;
            // 
            // picBLatchA2Alu
            // 
            this.picBLatchA2Alu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBLatchA2Alu.Location = new System.Drawing.Point(272, 282);
            this.picBLatchA2Alu.Name = "picBLatchA2Alu";
            this.picBLatchA2Alu.Size = new System.Drawing.Size(10, 48);
            this.picBLatchA2Alu.TabIndex = 38;
            this.picBLatchA2Alu.TabStop = false;
            // 
            // picBLatchB2Alu
            // 
            this.picBLatchB2Alu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBLatchB2Alu.Location = new System.Drawing.Point(352, 282);
            this.picBLatchB2Alu.Name = "picBLatchB2Alu";
            this.picBLatchB2Alu.Size = new System.Drawing.Size(10, 104);
            this.picBLatchB2Alu.TabIndex = 39;
            this.picBLatchB2Alu.TabStop = false;
            // 
            // picBMbr2Amux4
            // 
            this.picBMbr2Amux4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMbr2Amux4.Location = new System.Drawing.Point(200, 338);
            this.picBMbr2Amux4.Name = "picBMbr2Amux4";
            this.picBMbr2Amux4.Size = new System.Drawing.Size(48, 10);
            this.picBMbr2Amux4.TabIndex = 40;
            this.picBMbr2Amux4.TabStop = false;
            // 
            // picBMbr2Amux3
            // 
            this.picBMbr2Amux3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMbr2Amux3.Location = new System.Drawing.Point(200, 346);
            this.picBMbr2Amux3.Name = "picBMbr2Amux3";
            this.picBMbr2Amux3.Size = new System.Drawing.Size(10, 136);
            this.picBMbr2Amux3.TabIndex = 41;
            this.picBMbr2Amux3.TabStop = false;
            // 
            // picBMbr2Amux2
            // 
            this.picBMbr2Amux2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMbr2Amux2.Location = new System.Drawing.Point(104, 474);
            this.picBMbr2Amux2.Name = "picBMbr2Amux2";
            this.picBMbr2Amux2.Size = new System.Drawing.Size(105, 10);
            this.picBMbr2Amux2.TabIndex = 42;
            this.picBMbr2Amux2.TabStop = false;
            // 
            // picBMbr2Amux1
            // 
            this.picBMbr2Amux1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMbr2Amux1.Location = new System.Drawing.Point(104, 474);
            this.picBMbr2Amux1.Name = "picBMbr2Amux1";
            this.picBMbr2Amux1.Size = new System.Drawing.Size(10, 24);
            this.picBMbr2Amux1.TabIndex = 43;
            this.picBMbr2Amux1.TabStop = false;
            // 
            // picBLatchB2Mar1
            // 
            this.picBLatchB2Mar1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBLatchB2Mar1.Location = new System.Drawing.Point(232, 298);
            this.picBLatchB2Mar1.Name = "picBLatchB2Mar1";
            this.picBLatchB2Mar1.Size = new System.Drawing.Size(120, 10);
            this.picBLatchB2Mar1.TabIndex = 44;
            this.picBLatchB2Mar1.TabStop = false;
            // 
            // picBLatchB2Mar2
            // 
            this.picBLatchB2Mar2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBLatchB2Mar2.Location = new System.Drawing.Point(229, 298);
            this.picBLatchB2Mar2.Name = "picBLatchB2Mar2";
            this.picBLatchB2Mar2.Size = new System.Drawing.Size(10, 144);
            this.picBLatchB2Mar2.TabIndex = 45;
            this.picBLatchB2Mar2.TabStop = false;
            // 
            // picBLatchB2Mar3
            // 
            this.picBLatchB2Mar3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBLatchB2Mar3.Location = new System.Drawing.Point(144, 442);
            this.picBLatchB2Mar3.Name = "picBLatchB2Mar3";
            this.picBLatchB2Mar3.Size = new System.Drawing.Size(95, 10);
            this.picBLatchB2Mar3.TabIndex = 46;
            this.picBLatchB2Mar3.TabStop = false;
            // 
            // picBPc2Latch
            // 
            this.picBPc2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBPc2Latch.Location = new System.Drawing.Point(168, 26);
            this.picBPc2Latch.Name = "picBPc2Latch";
            this.picBPc2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBPc2Latch.TabIndex = 47;
            this.picBPc2Latch.TabStop = false;
            // 
            // picBAc2Latch
            // 
            this.picBAc2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBAc2Latch.Location = new System.Drawing.Point(168, 47);
            this.picBAc2Latch.Name = "picBAc2Latch";
            this.picBAc2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBAc2Latch.TabIndex = 48;
            this.picBAc2Latch.TabStop = false;
            // 
            // picBSp2Latch
            // 
            this.picBSp2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBSp2Latch.Location = new System.Drawing.Point(168, 71);
            this.picBSp2Latch.Name = "picBSp2Latch";
            this.picBSp2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBSp2Latch.TabIndex = 49;
            this.picBSp2Latch.TabStop = false;
            // 
            // picBIr2Latch
            // 
            this.picBIr2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBIr2Latch.Location = new System.Drawing.Point(168, 95);
            this.picBIr2Latch.Name = "picBIr2Latch";
            this.picBIr2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBIr2Latch.TabIndex = 50;
            this.picBIr2Latch.TabStop = false;
            // 
            // picBTir2Latch
            // 
            this.picBTir2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBTir2Latch.Location = new System.Drawing.Point(168, 118);
            this.picBTir2Latch.Name = "picBTir2Latch";
            this.picBTir2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBTir2Latch.TabIndex = 51;
            this.picBTir2Latch.TabStop = false;
            // 
            // picBZero2Latch
            // 
            this.picBZero2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBZero2Latch.Location = new System.Drawing.Point(168, 142);
            this.picBZero2Latch.Name = "picBZero2Latch";
            this.picBZero2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBZero2Latch.TabIndex = 52;
            this.picBZero2Latch.TabStop = false;
            // 
            // picBMaisUm2Latch
            // 
            this.picBMaisUm2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBMaisUm2Latch.Location = new System.Drawing.Point(168, 167);
            this.picBMaisUm2Latch.Name = "picBMaisUm2Latch";
            this.picBMaisUm2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBMaisUm2Latch.TabIndex = 53;
            this.picBMaisUm2Latch.TabStop = false;
            // 
            // picBMenosUm2Latch
            // 
            this.picBMenosUm2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBMenosUm2Latch.Location = new System.Drawing.Point(168, 190);
            this.picBMenosUm2Latch.Name = "picBMenosUm2Latch";
            this.picBMenosUm2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBMenosUm2Latch.TabIndex = 54;
            this.picBMenosUm2Latch.TabStop = false;
            // 
            // picBAmask2Latch
            // 
            this.picBAmask2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBAmask2Latch.Location = new System.Drawing.Point(168, 214);
            this.picBAmask2Latch.Name = "picBAmask2Latch";
            this.picBAmask2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBAmask2Latch.TabIndex = 55;
            this.picBAmask2Latch.TabStop = false;
            // 
            // picBSmask2Latch
            // 
            this.picBSmask2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBSmask2Latch.Location = new System.Drawing.Point(168, 238);
            this.picBSmask2Latch.Name = "picBSmask2Latch";
            this.picBSmask2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBSmask2Latch.TabIndex = 56;
            this.picBSmask2Latch.TabStop = false;
            // 
            // picBA2Latch
            // 
            this.picBA2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBA2Latch.Location = new System.Drawing.Point(168, 263);
            this.picBA2Latch.Name = "picBA2Latch";
            this.picBA2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBA2Latch.TabIndex = 57;
            this.picBA2Latch.TabStop = false;
            // 
            // picBB2Latch
            // 
            this.picBB2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBB2Latch.Location = new System.Drawing.Point(168, 286);
            this.picBB2Latch.Name = "picBB2Latch";
            this.picBB2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBB2Latch.TabIndex = 58;
            this.picBB2Latch.TabStop = false;
            // 
            // picBC2Latch
            // 
            this.picBC2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBC2Latch.Location = new System.Drawing.Point(168, 311);
            this.picBC2Latch.Name = "picBC2Latch";
            this.picBC2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBC2Latch.TabIndex = 59;
            this.picBC2Latch.TabStop = false;
            // 
            // picBD2Latch
            // 
            this.picBD2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBD2Latch.Location = new System.Drawing.Point(168, 335);
            this.picBD2Latch.Name = "picBD2Latch";
            this.picBD2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBD2Latch.TabIndex = 60;
            this.picBD2Latch.TabStop = false;
            // 
            // picBE2Latch
            // 
            this.picBE2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBE2Latch.Location = new System.Drawing.Point(168, 359);
            this.picBE2Latch.Name = "picBE2Latch";
            this.picBE2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBE2Latch.TabIndex = 61;
            this.picBE2Latch.TabStop = false;
            // 
            // picBF2Latch
            // 
            this.picBF2Latch.BackColor = System.Drawing.Color.Teal;
            this.picBF2Latch.Location = new System.Drawing.Point(168, 383);
            this.picBF2Latch.Name = "picBF2Latch";
            this.picBF2Latch.Size = new System.Drawing.Size(16, 10);
            this.picBF2Latch.TabIndex = 62;
            this.picBF2Latch.TabStop = false;
            // 
            // picMirAmux
            // 
            this.picMirAmux.Image = ((System.Drawing.Image)(resources.GetObject("picMirAmux.Image")));
            this.picMirAmux.Location = new System.Drawing.Point(496, 234);
            this.picMirAmux.Name = "picMirAmux";
            this.picMirAmux.Size = new System.Drawing.Size(16, 40);
            this.picMirAmux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirAmux.TabIndex = 63;
            this.picMirAmux.TabStop = false;
            // 
            // picMirCond
            // 
            this.picMirCond.Image = ((System.Drawing.Image)(resources.GetObject("picMirCond.Image")));
            this.picMirCond.Location = new System.Drawing.Point(512, 234);
            this.picMirCond.Name = "picMirCond";
            this.picMirCond.Size = new System.Drawing.Size(16, 40);
            this.picMirCond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirCond.TabIndex = 64;
            this.picMirCond.TabStop = false;
            // 
            // picMirAlu
            // 
            this.picMirAlu.Image = ((System.Drawing.Image)(resources.GetObject("picMirAlu.Image")));
            this.picMirAlu.Location = new System.Drawing.Point(528, 234);
            this.picMirAlu.Name = "picMirAlu";
            this.picMirAlu.Size = new System.Drawing.Size(16, 40);
            this.picMirAlu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirAlu.TabIndex = 65;
            this.picMirAlu.TabStop = false;
            // 
            // picMirSh
            // 
            this.picMirSh.Image = ((System.Drawing.Image)(resources.GetObject("picMirSh.Image")));
            this.picMirSh.Location = new System.Drawing.Point(544, 234);
            this.picMirSh.Name = "picMirSh";
            this.picMirSh.Size = new System.Drawing.Size(16, 40);
            this.picMirSh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirSh.TabIndex = 66;
            this.picMirSh.TabStop = false;
            // 
            // picMirMbr
            // 
            this.picMirMbr.Image = ((System.Drawing.Image)(resources.GetObject("picMirMbr.Image")));
            this.picMirMbr.Location = new System.Drawing.Point(560, 234);
            this.picMirMbr.Name = "picMirMbr";
            this.picMirMbr.Size = new System.Drawing.Size(16, 40);
            this.picMirMbr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirMbr.TabIndex = 67;
            this.picMirMbr.TabStop = false;
            // 
            // picMirMar
            // 
            this.picMirMar.Image = ((System.Drawing.Image)(resources.GetObject("picMirMar.Image")));
            this.picMirMar.Location = new System.Drawing.Point(576, 234);
            this.picMirMar.Name = "picMirMar";
            this.picMirMar.Size = new System.Drawing.Size(16, 40);
            this.picMirMar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirMar.TabIndex = 68;
            this.picMirMar.TabStop = false;
            // 
            // picMirRd
            // 
            this.picMirRd.Image = ((System.Drawing.Image)(resources.GetObject("picMirRd.Image")));
            this.picMirRd.Location = new System.Drawing.Point(592, 234);
            this.picMirRd.Name = "picMirRd";
            this.picMirRd.Size = new System.Drawing.Size(16, 40);
            this.picMirRd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirRd.TabIndex = 69;
            this.picMirRd.TabStop = false;
            // 
            // picMirWr
            // 
            this.picMirWr.Image = ((System.Drawing.Image)(resources.GetObject("picMirWr.Image")));
            this.picMirWr.Location = new System.Drawing.Point(608, 234);
            this.picMirWr.Name = "picMirWr";
            this.picMirWr.Size = new System.Drawing.Size(16, 40);
            this.picMirWr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirWr.TabIndex = 70;
            this.picMirWr.TabStop = false;
            // 
            // picMirEnc
            // 
            this.picMirEnc.Image = ((System.Drawing.Image)(resources.GetObject("picMirEnc.Image")));
            this.picMirEnc.Location = new System.Drawing.Point(624, 234);
            this.picMirEnc.Name = "picMirEnc";
            this.picMirEnc.Size = new System.Drawing.Size(16, 40);
            this.picMirEnc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirEnc.TabIndex = 71;
            this.picMirEnc.TabStop = false;
            // 
            // picMirC
            // 
            this.picMirC.Image = ((System.Drawing.Image)(resources.GetObject("picMirC.Image")));
            this.picMirC.Location = new System.Drawing.Point(640, 234);
            this.picMirC.Name = "picMirC";
            this.picMirC.Size = new System.Drawing.Size(16, 40);
            this.picMirC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirC.TabIndex = 72;
            this.picMirC.TabStop = false;
            // 
            // picMirB
            // 
            this.picMirB.Image = ((System.Drawing.Image)(resources.GetObject("picMirB.Image")));
            this.picMirB.Location = new System.Drawing.Point(656, 234);
            this.picMirB.Name = "picMirB";
            this.picMirB.Size = new System.Drawing.Size(16, 40);
            this.picMirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirB.TabIndex = 73;
            this.picMirB.TabStop = false;
            // 
            // picMirA
            // 
            this.picMirA.Image = ((System.Drawing.Image)(resources.GetObject("picMirA.Image")));
            this.picMirA.Location = new System.Drawing.Point(672, 234);
            this.picMirA.Name = "picMirA";
            this.picMirA.Size = new System.Drawing.Size(16, 40);
            this.picMirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirA.TabIndex = 74;
            this.picMirA.TabStop = false;
            // 
            // picMirAddr
            // 
            this.picMirAddr.Image = ((System.Drawing.Image)(resources.GetObject("picMirAddr.Image")));
            this.picMirAddr.Location = new System.Drawing.Point(688, 234);
            this.picMirAddr.Name = "picMirAddr";
            this.picMirAddr.Size = new System.Drawing.Size(16, 40);
            this.picMirAddr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMirAddr.TabIndex = 75;
            this.picMirAddr.TabStop = false;
            // 
            // picBDecodC2Reg1
            // 
            this.picBDecodC2Reg1.BackColor = System.Drawing.Color.Teal;
            this.picBDecodC2Reg1.Location = new System.Drawing.Point(264, 26);
            this.picBDecodC2Reg1.Name = "picBDecodC2Reg1";
            this.picBDecodC2Reg1.Size = new System.Drawing.Size(56, 10);
            this.picBDecodC2Reg1.TabIndex = 78;
            this.picBDecodC2Reg1.TabStop = false;
            // 
            // picBDecodB2Reg1
            // 
            this.picBDecodB2Reg1.BackColor = System.Drawing.Color.Teal;
            this.picBDecodB2Reg1.Location = new System.Drawing.Point(264, 58);
            this.picBDecodB2Reg1.Name = "picBDecodB2Reg1";
            this.picBDecodB2Reg1.Size = new System.Drawing.Size(56, 10);
            this.picBDecodB2Reg1.TabIndex = 79;
            this.picBDecodB2Reg1.TabStop = false;
            // 
            // picBDecodA2Reg1
            // 
            this.picBDecodA2Reg1.BackColor = System.Drawing.Color.Teal;
            this.picBDecodA2Reg1.Location = new System.Drawing.Point(264, 90);
            this.picBDecodA2Reg1.Name = "picBDecodA2Reg1";
            this.picBDecodA2Reg1.Size = new System.Drawing.Size(56, 10);
            this.picBDecodA2Reg1.TabIndex = 80;
            this.picBDecodA2Reg1.TabStop = false;
            // 
            // picBMirAmux2Amux1
            // 
            this.picBMirAmux2Amux1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirAmux2Amux1.Location = new System.Drawing.Point(504, 274);
            this.picBMirAmux2Amux1.Name = "picBMirAmux2Amux1";
            this.picBMirAmux2Amux1.Size = new System.Drawing.Size(3, 72);
            this.picBMirAmux2Amux1.TabIndex = 81;
            this.picBMirAmux2Amux1.TabStop = false;
            // 
            // picBMirAmux2Amux2
            // 
            this.picBMirAmux2Amux2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirAmux2Amux2.Location = new System.Drawing.Point(320, 346);
            this.picBMirAmux2Amux2.Name = "picBMirAmux2Amux2";
            this.picBMirAmux2Amux2.Size = new System.Drawing.Size(187, 3);
            this.picBMirAmux2Amux2.TabIndex = 82;
            this.picBMirAmux2Amux2.TabStop = false;
            // 
            // picBMirCond2Lms1
            // 
            this.picBMirCond2Lms1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirCond2Lms1.Location = new System.Drawing.Point(520, 274);
            this.picBMirCond2Lms1.Name = "picBMirCond2Lms1";
            this.picBMirCond2Lms1.Size = new System.Drawing.Size(3, 152);
            this.picBMirCond2Lms1.TabIndex = 83;
            this.picBMirCond2Lms1.TabStop = false;
            // 
            // picBMirCond2Lms2
            // 
            this.picBMirCond2Lms2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirCond2Lms2.Location = new System.Drawing.Point(496, 426);
            this.picBMirCond2Lms2.Name = "picBMirCond2Lms2";
            this.picBMirCond2Lms2.Size = new System.Drawing.Size(27, 3);
            this.picBMirCond2Lms2.TabIndex = 84;
            this.picBMirCond2Lms2.TabStop = false;
            // 
            // picBMirAlu2Alu1
            // 
            this.picBMirAlu2Alu1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirAlu2Alu1.Location = new System.Drawing.Point(536, 274);
            this.picBMirAlu2Alu1.Name = "picBMirAlu2Alu1";
            this.picBMirAlu2Alu1.Size = new System.Drawing.Size(3, 176);
            this.picBMirAlu2Alu1.TabIndex = 85;
            this.picBMirAlu2Alu1.TabStop = false;
            // 
            // picBMirAlu2Alu2
            // 
            this.picBMirAlu2Alu2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirAlu2Alu2.Location = new System.Drawing.Point(392, 450);
            this.picBMirAlu2Alu2.Name = "picBMirAlu2Alu2";
            this.picBMirAlu2Alu2.Size = new System.Drawing.Size(147, 3);
            this.picBMirAlu2Alu2.TabIndex = 86;
            this.picBMirAlu2Alu2.TabStop = false;
            // 
            // picBAluN2LMS
            // 
            this.picBAluN2LMS.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBAluN2LMS.Location = new System.Drawing.Point(392, 418);
            this.picBAluN2LMS.Name = "picBAluN2LMS";
            this.picBAluN2LMS.Size = new System.Drawing.Size(40, 3);
            this.picBAluN2LMS.TabIndex = 87;
            this.picBAluN2LMS.TabStop = false;
            // 
            // picBAluZ2LMS
            // 
            this.picBAluZ2LMS.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBAluZ2LMS.Location = new System.Drawing.Point(392, 434);
            this.picBAluZ2LMS.Name = "picBAluZ2LMS";
            this.picBAluZ2LMS.Size = new System.Drawing.Size(40, 3);
            this.picBAluZ2LMS.TabIndex = 88;
            this.picBAluZ2LMS.TabStop = false;
            // 
            // picBMirSh2Desloc1
            // 
            this.picBMirSh2Desloc1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirSh2Desloc1.Location = new System.Drawing.Point(552, 274);
            this.picBMirSh2Desloc1.Name = "picBMirSh2Desloc1";
            this.picBMirSh2Desloc1.Size = new System.Drawing.Size(3, 240);
            this.picBMirSh2Desloc1.TabIndex = 89;
            this.picBMirSh2Desloc1.TabStop = false;
            // 
            // picBMirSh2Desloc2
            // 
            this.picBMirSh2Desloc2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirSh2Desloc2.Location = new System.Drawing.Point(352, 514);
            this.picBMirSh2Desloc2.Name = "picBMirSh2Desloc2";
            this.picBMirSh2Desloc2.Size = new System.Drawing.Size(203, 3);
            this.picBMirSh2Desloc2.TabIndex = 90;
            this.picBMirSh2Desloc2.TabStop = false;
            // 
            // picBMirMbr2Mbr3
            // 
            this.picBMirMbr2Mbr3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirMbr2Mbr3.Location = new System.Drawing.Point(128, 522);
            this.picBMirMbr2Mbr3.Name = "picBMirMbr2Mbr3";
            this.picBMirMbr2Mbr3.Size = new System.Drawing.Size(3, 8);
            this.picBMirMbr2Mbr3.TabIndex = 91;
            this.picBMirMbr2Mbr3.TabStop = false;
            // 
            // picBMirMbr2Mbr1
            // 
            this.picBMirMbr2Mbr1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirMbr2Mbr1.Location = new System.Drawing.Point(568, 274);
            this.picBMirMbr2Mbr1.Name = "picBMirMbr2Mbr1";
            this.picBMirMbr2Mbr1.Size = new System.Drawing.Size(3, 256);
            this.picBMirMbr2Mbr1.TabIndex = 92;
            this.picBMirMbr2Mbr1.TabStop = false;
            // 
            // picBMirMbr2Mbr2
            // 
            this.picBMirMbr2Mbr2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirMbr2Mbr2.Location = new System.Drawing.Point(128, 530);
            this.picBMirMbr2Mbr2.Name = "picBMirMbr2Mbr2";
            this.picBMirMbr2Mbr2.Size = new System.Drawing.Size(443, 3);
            this.picBMirMbr2Mbr2.TabIndex = 93;
            this.picBMirMbr2Mbr2.TabStop = false;
            // 
            // picBMirMar2Mar3
            // 
            this.picBMirMar2Mar3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirMar2Mar3.Location = new System.Drawing.Point(64, 442);
            this.picBMirMar2Mar3.Name = "picBMirMar2Mar3";
            this.picBMirMar2Mar3.Size = new System.Drawing.Size(3, 112);
            this.picBMirMar2Mar3.TabIndex = 94;
            this.picBMirMar2Mar3.TabStop = false;
            // 
            // picBMirMar2Mar4
            // 
            this.picBMirMar2Mar4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirMar2Mar4.Location = new System.Drawing.Point(64, 442);
            this.picBMirMar2Mar4.Name = "picBMirMar2Mar4";
            this.picBMirMar2Mar4.Size = new System.Drawing.Size(16, 3);
            this.picBMirMar2Mar4.TabIndex = 95;
            this.picBMirMar2Mar4.TabStop = false;
            // 
            // picBAddr2Mmux1
            // 
            this.picBAddr2Mmux1.BackColor = System.Drawing.Color.Teal;
            this.picBAddr2Mmux1.Location = new System.Drawing.Point(688, 66);
            this.picBAddr2Mmux1.Name = "picBAddr2Mmux1";
            this.picBAddr2Mmux1.Size = new System.Drawing.Size(10, 168);
            this.picBAddr2Mmux1.TabIndex = 96;
            this.picBAddr2Mmux1.TabStop = false;
            // 
            // picBAddr2Mmux2
            // 
            this.picBAddr2Mmux2.BackColor = System.Drawing.Color.Teal;
            this.picBAddr2Mmux2.Location = new System.Drawing.Point(568, 66);
            this.picBAddr2Mmux2.Name = "picBAddr2Mmux2";
            this.picBAddr2Mmux2.Size = new System.Drawing.Size(128, 10);
            this.picBAddr2Mmux2.TabIndex = 97;
            this.picBAddr2Mmux2.TabStop = false;
            // 
            // picBAddr2Mmux3
            // 
            this.picBAddr2Mmux3.BackColor = System.Drawing.Color.Teal;
            this.picBAddr2Mmux3.Location = new System.Drawing.Point(568, 74);
            this.picBAddr2Mmux3.Name = "picBAddr2Mmux3";
            this.picBAddr2Mmux3.Size = new System.Drawing.Size(10, 16);
            this.picBAddr2Mmux3.TabIndex = 98;
            this.picBAddr2Mmux3.TabStop = false;
            // 
            // picBMmux2Mpc
            // 
            this.picBMmux2Mpc.BackColor = System.Drawing.Color.Teal;
            this.picBMmux2Mpc.Location = new System.Drawing.Point(556, 114);
            this.picBMmux2Mpc.Name = "picBMmux2Mpc";
            this.picBMmux2Mpc.Size = new System.Drawing.Size(10, 16);
            this.picBMmux2Mpc.TabIndex = 99;
            this.picBMmux2Mpc.TabStop = false;
            // 
            // picBMirMar2Mar1
            // 
            this.picBMirMar2Mar1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirMar2Mar1.Location = new System.Drawing.Point(584, 274);
            this.picBMirMar2Mar1.Name = "picBMirMar2Mar1";
            this.picBMirMar2Mar1.Size = new System.Drawing.Size(3, 280);
            this.picBMirMar2Mar1.TabIndex = 100;
            this.picBMirMar2Mar1.TabStop = false;
            // 
            // picBMirEnc2DecodC2
            // 
            this.picBMirEnc2DecodC2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirEnc2DecodC2.Location = new System.Drawing.Point(632, 554);
            this.picBMirEnc2DecodC2.Name = "picBMirEnc2DecodC2";
            this.picBMirEnc2DecodC2.Size = new System.Drawing.Size(115, 3);
            this.picBMirEnc2DecodC2.TabIndex = 101;
            this.picBMirEnc2DecodC2.TabStop = false;
            // 
            // picBMirEnc2DecodC3
            // 
            this.picBMirEnc2DecodC3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirEnc2DecodC3.Location = new System.Drawing.Point(744, 26);
            this.picBMirEnc2DecodC3.Name = "picBMirEnc2DecodC3";
            this.picBMirEnc2DecodC3.Size = new System.Drawing.Size(3, 528);
            this.picBMirEnc2DecodC3.TabIndex = 102;
            this.picBMirEnc2DecodC3.TabStop = false;
            // 
            // picBMirEnc2DecodC4
            // 
            this.picBMirEnc2DecodC4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirEnc2DecodC4.Location = new System.Drawing.Point(376, 26);
            this.picBMirEnc2DecodC4.Name = "picBMirEnc2DecodC4";
            this.picBMirEnc2DecodC4.Size = new System.Drawing.Size(368, 3);
            this.picBMirEnc2DecodC4.TabIndex = 103;
            this.picBMirEnc2DecodC4.TabStop = false;
            // 
            // picBMirC2DecodC1
            // 
            this.picBMirC2DecodC1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirC2DecodC1.Location = new System.Drawing.Point(648, 274);
            this.picBMirC2DecodC1.Name = "picBMirC2DecodC1";
            this.picBMirC2DecodC1.Size = new System.Drawing.Size(3, 272);
            this.picBMirC2DecodC1.TabIndex = 104;
            this.picBMirC2DecodC1.TabStop = false;
            // 
            // picBMirC2DecodC2
            // 
            this.picBMirC2DecodC2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirC2DecodC2.Location = new System.Drawing.Point(648, 546);
            this.picBMirC2DecodC2.Name = "picBMirC2DecodC2";
            this.picBMirC2DecodC2.Size = new System.Drawing.Size(91, 3);
            this.picBMirC2DecodC2.TabIndex = 105;
            this.picBMirC2DecodC2.TabStop = false;
            // 
            // picBMirC2DecodC3
            // 
            this.picBMirC2DecodC3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirC2DecodC3.Location = new System.Drawing.Point(736, 34);
            this.picBMirC2DecodC3.Name = "picBMirC2DecodC3";
            this.picBMirC2DecodC3.Size = new System.Drawing.Size(3, 512);
            this.picBMirC2DecodC3.TabIndex = 106;
            this.picBMirC2DecodC3.TabStop = false;
            // 
            // picBMirC2DecodC4
            // 
            this.picBMirC2DecodC4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirC2DecodC4.Location = new System.Drawing.Point(376, 34);
            this.picBMirC2DecodC4.Name = "picBMirC2DecodC4";
            this.picBMirC2DecodC4.Size = new System.Drawing.Size(360, 3);
            this.picBMirC2DecodC4.TabIndex = 107;
            this.picBMirC2DecodC4.TabStop = false;
            // 
            // picBMirB2DecodB1
            // 
            this.picBMirB2DecodB1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirB2DecodB1.Location = new System.Drawing.Point(664, 274);
            this.picBMirB2DecodB1.Name = "picBMirB2DecodB1";
            this.picBMirB2DecodB1.Size = new System.Drawing.Size(3, 264);
            this.picBMirB2DecodB1.TabIndex = 110;
            this.picBMirB2DecodB1.TabStop = false;
            // 
            // picBMirB2DecodB2
            // 
            this.picBMirB2DecodB2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirB2DecodB2.Location = new System.Drawing.Point(664, 538);
            this.picBMirB2DecodB2.Name = "picBMirB2DecodB2";
            this.picBMirB2DecodB2.Size = new System.Drawing.Size(67, 3);
            this.picBMirB2DecodB2.TabIndex = 111;
            this.picBMirB2DecodB2.TabStop = false;
            // 
            // picBMirB2DecodB3
            // 
            this.picBMirB2DecodB3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirB2DecodB3.Location = new System.Drawing.Point(728, 42);
            this.picBMirB2DecodB3.Name = "picBMirB2DecodB3";
            this.picBMirB2DecodB3.Size = new System.Drawing.Size(3, 496);
            this.picBMirB2DecodB3.TabIndex = 112;
            this.picBMirB2DecodB3.TabStop = false;
            // 
            // picBMirB2DecodB4
            // 
            this.picBMirB2DecodB4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirB2DecodB4.Location = new System.Drawing.Point(400, 42);
            this.picBMirB2DecodB4.Name = "picBMirB2DecodB4";
            this.picBMirB2DecodB4.Size = new System.Drawing.Size(328, 3);
            this.picBMirB2DecodB4.TabIndex = 113;
            this.picBMirB2DecodB4.TabStop = false;
            // 
            // picBMirB2DecodB5
            // 
            this.picBMirB2DecodB5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirB2DecodB5.Location = new System.Drawing.Point(400, 42);
            this.picBMirB2DecodB5.Name = "picBMirB2DecodB5";
            this.picBMirB2DecodB5.Size = new System.Drawing.Size(3, 16);
            this.picBMirB2DecodB5.TabIndex = 114;
            this.picBMirB2DecodB5.TabStop = false;
            // 
            // picBMirB2DecodB6
            // 
            this.picBMirB2DecodB6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirB2DecodB6.Location = new System.Drawing.Point(376, 58);
            this.picBMirB2DecodB6.Name = "picBMirB2DecodB6";
            this.picBMirB2DecodB6.Size = new System.Drawing.Size(27, 3);
            this.picBMirB2DecodB6.TabIndex = 115;
            this.picBMirB2DecodB6.TabStop = false;
            // 
            // picBMirA2DecodA4
            // 
            this.picBMirA2DecodA4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirA2DecodA4.Location = new System.Drawing.Point(424, 50);
            this.picBMirA2DecodA4.Name = "picBMirA2DecodA4";
            this.picBMirA2DecodA4.Size = new System.Drawing.Size(296, 3);
            this.picBMirA2DecodA4.TabIndex = 116;
            this.picBMirA2DecodA4.TabStop = false;
            // 
            // picBMirA2DecodA5
            // 
            this.picBMirA2DecodA5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirA2DecodA5.Location = new System.Drawing.Point(424, 50);
            this.picBMirA2DecodA5.Name = "picBMirA2DecodA5";
            this.picBMirA2DecodA5.Size = new System.Drawing.Size(3, 40);
            this.picBMirA2DecodA5.TabIndex = 117;
            this.picBMirA2DecodA5.TabStop = false;
            // 
            // picBMirA2DecodA6
            // 
            this.picBMirA2DecodA6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirA2DecodA6.Location = new System.Drawing.Point(376, 90);
            this.picBMirA2DecodA6.Name = "picBMirA2DecodA6";
            this.picBMirA2DecodA6.Size = new System.Drawing.Size(51, 3);
            this.picBMirA2DecodA6.TabIndex = 118;
            this.picBMirA2DecodA6.TabStop = false;
            // 
            // picBMirA2DecodA3
            // 
            this.picBMirA2DecodA3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirA2DecodA3.Location = new System.Drawing.Point(720, 50);
            this.picBMirA2DecodA3.Name = "picBMirA2DecodA3";
            this.picBMirA2DecodA3.Size = new System.Drawing.Size(3, 480);
            this.picBMirA2DecodA3.TabIndex = 119;
            this.picBMirA2DecodA3.TabStop = false;
            // 
            // picBMirA2DecodA2
            // 
            this.picBMirA2DecodA2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirA2DecodA2.Location = new System.Drawing.Point(680, 530);
            this.picBMirA2DecodA2.Name = "picBMirA2DecodA2";
            this.picBMirA2DecodA2.Size = new System.Drawing.Size(43, 3);
            this.picBMirA2DecodA2.TabIndex = 120;
            this.picBMirA2DecodA2.TabStop = false;
            // 
            // picBMirA2DecodA1
            // 
            this.picBMirA2DecodA1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirA2DecodA1.Location = new System.Drawing.Point(680, 274);
            this.picBMirA2DecodA1.Name = "picBMirA2DecodA1";
            this.picBMirA2DecodA1.Size = new System.Drawing.Size(3, 256);
            this.picBMirA2DecodA1.TabIndex = 121;
            this.picBMirA2DecodA1.TabStop = false;
            // 
            // picBMirMar2Mar2
            // 
            this.picBMirMar2Mar2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirMar2Mar2.Location = new System.Drawing.Point(64, 554);
            this.picBMirMar2Mar2.Name = "picBMirMar2Mar2";
            this.picBMirMar2Mar2.Size = new System.Drawing.Size(523, 3);
            this.picBMirMar2Mar2.TabIndex = 122;
            this.picBMirMar2Mar2.TabStop = false;
            // 
            // picBMirEnc2DecodC1
            // 
            this.picBMirEnc2DecodC1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirEnc2DecodC1.Location = new System.Drawing.Point(632, 274);
            this.picBMirEnc2DecodC1.Name = "picBMirEnc2DecodC1";
            this.picBMirEnc2DecodC1.Size = new System.Drawing.Size(3, 280);
            this.picBMirEnc2DecodC1.TabIndex = 123;
            this.picBMirEnc2DecodC1.TabStop = false;
            // 
            // picBMirRd2Mbr1
            // 
            this.picBMirRd2Mbr1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirRd2Mbr1.Location = new System.Drawing.Point(600, 274);
            this.picBMirRd2Mbr1.Name = "picBMirRd2Mbr1";
            this.picBMirRd2Mbr1.Size = new System.Drawing.Size(3, 264);
            this.picBMirRd2Mbr1.TabIndex = 124;
            this.picBMirRd2Mbr1.TabStop = false;
            // 
            // picBMirWr2Mbr1
            // 
            this.picBMirWr2Mbr1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirWr2Mbr1.Location = new System.Drawing.Point(616, 274);
            this.picBMirWr2Mbr1.Name = "picBMirWr2Mbr1";
            this.picBMirWr2Mbr1.Size = new System.Drawing.Size(3, 272);
            this.picBMirWr2Mbr1.TabIndex = 125;
            this.picBMirWr2Mbr1.TabStop = false;
            // 
            // picBMirRd2Mbr2
            // 
            this.picBMirRd2Mbr2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirRd2Mbr2.Location = new System.Drawing.Point(51, 538);
            this.picBMirRd2Mbr2.Name = "picBMirRd2Mbr2";
            this.picBMirRd2Mbr2.Size = new System.Drawing.Size(552, 3);
            this.picBMirRd2Mbr2.TabIndex = 126;
            this.picBMirRd2Mbr2.TabStop = false;
            // 
            // picBMirRd2Mbr3
            // 
            this.picBMirRd2Mbr3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirRd2Mbr3.Location = new System.Drawing.Point(112, 522);
            this.picBMirRd2Mbr3.Name = "picBMirRd2Mbr3";
            this.picBMirRd2Mbr3.Size = new System.Drawing.Size(3, 16);
            this.picBMirRd2Mbr3.TabIndex = 127;
            this.picBMirRd2Mbr3.TabStop = false;
            // 
            // picBMirWr2Mbr2
            // 
            this.picBMirWr2Mbr2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBMirWr2Mbr2.Location = new System.Drawing.Point(51, 546);
            this.picBMirWr2Mbr2.Name = "picBMirWr2Mbr2";
            this.picBMirWr2Mbr2.Size = new System.Drawing.Size(568, 3);
            this.picBMirWr2Mbr2.TabIndex = 128;
            this.picBMirWr2Mbr2.TabStop = false;
            // 
            // picBMirWr2Mbr3
            // 
            this.picBMirWr2Mbr3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBMirWr2Mbr3.Location = new System.Drawing.Point(96, 522);
            this.picBMirWr2Mbr3.Name = "picBMirWr2Mbr3";
            this.picBMirWr2Mbr3.Size = new System.Drawing.Size(3, 24);
            this.picBMirWr2Mbr3.TabIndex = 129;
            this.picBMirWr2Mbr3.TabStop = false;
            // 
            // picBMpc2MemControle
            // 
            this.picBMpc2MemControle.BackColor = System.Drawing.Color.Teal;
            this.picBMpc2MemControle.Location = new System.Drawing.Point(557, 154);
            this.picBMpc2MemControle.Name = "picBMpc2MemControle";
            this.picBMpc2MemControle.Size = new System.Drawing.Size(10, 16);
            this.picBMpc2MemControle.TabIndex = 130;
            this.picBMpc2MemControle.TabStop = false;
            // 
            // picMemControle
            // 
            this.picMemControle.Image = ((System.Drawing.Image)(resources.GetObject("picMemControle.Image")));
            this.picMemControle.Location = new System.Drawing.Point(512, 170);
            this.picMemControle.Name = "picMemControle";
            this.picMemControle.Size = new System.Drawing.Size(160, 32);
            this.picMemControle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMemControle.TabIndex = 131;
            this.picMemControle.TabStop = false;
            // 
            // picBIncrem2Mmux2
            // 
            this.picBIncrem2Mmux2.BackColor = System.Drawing.Color.Teal;
            this.picBIncrem2Mmux2.Location = new System.Drawing.Point(456, 66);
            this.picBIncrem2Mmux2.Name = "picBIncrem2Mmux2";
            this.picBIncrem2Mmux2.Size = new System.Drawing.Size(96, 10);
            this.picBIncrem2Mmux2.TabIndex = 132;
            this.picBIncrem2Mmux2.TabStop = false;
            // 
            // picBIncrem2Mmux3
            // 
            this.picBIncrem2Mmux3.BackColor = System.Drawing.Color.Teal;
            this.picBIncrem2Mmux3.Location = new System.Drawing.Point(544, 66);
            this.picBIncrem2Mmux3.Name = "picBIncrem2Mmux3";
            this.picBIncrem2Mmux3.Size = new System.Drawing.Size(10, 24);
            this.picBIncrem2Mmux3.TabIndex = 133;
            this.picBIncrem2Mmux3.TabStop = false;
            // 
            // picBIncrem2Mmux1
            // 
            this.picBIncrem2Mmux1.BackColor = System.Drawing.Color.Teal;
            this.picBIncrem2Mmux1.Location = new System.Drawing.Point(448, 66);
            this.picBIncrem2Mmux1.Name = "picBIncrem2Mmux1";
            this.picBIncrem2Mmux1.Size = new System.Drawing.Size(10, 64);
            this.picBIncrem2Mmux1.TabIndex = 134;
            this.picBIncrem2Mmux1.TabStop = false;
            // 
            // picBMpc2Incrementador
            // 
            this.picBMpc2Incrementador.BackColor = System.Drawing.Color.Teal;
            this.picBMpc2Incrementador.Location = new System.Drawing.Point(488, 138);
            this.picBMpc2Incrementador.Name = "picBMpc2Incrementador";
            this.picBMpc2Incrementador.Size = new System.Drawing.Size(48, 10);
            this.picBMpc2Incrementador.TabIndex = 136;
            this.picBMpc2Incrementador.TabStop = false;
            // 
            // picBMemControle2Mir
            // 
            this.picBMemControle2Mir.BackColor = System.Drawing.Color.Teal;
            this.picBMemControle2Mir.Location = new System.Drawing.Point(559, 202);
            this.picBMemControle2Mir.Name = "picBMemControle2Mir";
            this.picBMemControle2Mir.Size = new System.Drawing.Size(10, 32);
            this.picBMemControle2Mir.TabIndex = 137;
            this.picBMemControle2Mir.TabStop = false;
            // 
            // picBAmux2Alu
            // 
            this.picBAmux2Alu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBAmux2Alu.Location = new System.Drawing.Point(272, 362);
            this.picBAmux2Alu.Name = "picBAmux2Alu";
            this.picBAmux2Alu.Size = new System.Drawing.Size(10, 24);
            this.picBAmux2Alu.TabIndex = 138;
            this.picBAmux2Alu.TabStop = false;
            // 
            // picBLms2Mpc1
            // 
            this.picBLms2Mpc1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBLms2Mpc1.Location = new System.Drawing.Point(464, 162);
            this.picBLms2Mpc1.Name = "picBLms2Mpc1";
            this.picBLms2Mpc1.Size = new System.Drawing.Size(3, 248);
            this.picBLms2Mpc1.TabIndex = 139;
            this.picBLms2Mpc1.TabStop = false;
            // 
            // picBLms2Mpc2
            // 
            this.picBLms2Mpc2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.picBLms2Mpc2.Location = new System.Drawing.Point(464, 162);
            this.picBLms2Mpc2.Name = "picBLms2Mpc2";
            this.picBLms2Mpc2.Size = new System.Drawing.Size(83, 3);
            this.picBLms2Mpc2.TabIndex = 140;
            this.picBLms2Mpc2.TabStop = false;
            // 
            // picBLms2Mpc3
            // 
            this.picBLms2Mpc3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBLms2Mpc3.Location = new System.Drawing.Point(544, 154);
            this.picBLms2Mpc3.Name = "picBLms2Mpc3";
            this.picBLms2Mpc3.Size = new System.Drawing.Size(3, 8);
            this.picBLms2Mpc3.TabIndex = 141;
            this.picBLms2Mpc3.TabStop = false;
            // 
            // picBDesloc2Reg2
            // 
            this.picBDesloc2Reg2.BackColor = System.Drawing.Color.Teal;
            this.picBDesloc2Reg2.Location = new System.Drawing.Point(160, 410);
            this.picBDesloc2Reg2.Name = "picBDesloc2Reg2";
            this.picBDesloc2Reg2.Size = new System.Drawing.Size(10, 94);
            this.picBDesloc2Reg2.TabIndex = 142;
            this.picBDesloc2Reg2.TabStop = false;
            // 
            // picBDesloc2Reg3
            // 
            this.picBDesloc2Reg3.BackColor = System.Drawing.Color.Teal;
            this.picBDesloc2Reg3.Location = new System.Drawing.Point(73, 410);
            this.picBDesloc2Reg3.Name = "picBDesloc2Reg3";
            this.picBDesloc2Reg3.Size = new System.Drawing.Size(96, 10);
            this.picBDesloc2Reg3.TabIndex = 143;
            this.picBDesloc2Reg3.TabStop = false;
            // 
            // picBDesloc2Reg4
            // 
            this.picBDesloc2Reg4.BackColor = System.Drawing.Color.Teal;
            this.picBDesloc2Reg4.Location = new System.Drawing.Point(72, 26);
            this.picBDesloc2Reg4.Name = "picBDesloc2Reg4";
            this.picBDesloc2Reg4.Size = new System.Drawing.Size(10, 392);
            this.picBDesloc2Reg4.TabIndex = 144;
            this.picBDesloc2Reg4.TabStop = false;
            // 
            // picBReg2Pc
            // 
            this.picBReg2Pc.BackColor = System.Drawing.Color.Teal;
            this.picBReg2Pc.Location = new System.Drawing.Point(72, 26);
            this.picBReg2Pc.Name = "picBReg2Pc";
            this.picBReg2Pc.Size = new System.Drawing.Size(48, 10);
            this.picBReg2Pc.TabIndex = 145;
            this.picBReg2Pc.TabStop = false;
            // 
            // picBDecoders2Reg1
            // 
            this.picBDecoders2Reg1.BackColor = System.Drawing.Color.Teal;
            this.picBDecoders2Reg1.Location = new System.Drawing.Point(264, 26);
            this.picBDecoders2Reg1.Name = "picBDecoders2Reg1";
            this.picBDecoders2Reg1.Size = new System.Drawing.Size(10, 66);
            this.picBDecoders2Reg1.TabIndex = 146;
            this.picBDecoders2Reg1.TabStop = false;
            // 
            // picBDecoders2Reg2
            // 
            this.picBDecoders2Reg2.BackColor = System.Drawing.Color.Teal;
            this.picBDecoders2Reg2.Location = new System.Drawing.Point(216, 58);
            this.picBDecoders2Reg2.Name = "picBDecoders2Reg2";
            this.picBDecoders2Reg2.Size = new System.Drawing.Size(56, 10);
            this.picBDecoders2Reg2.TabIndex = 147;
            this.picBDecoders2Reg2.TabStop = false;
            // 
            // picBDecoders2Reg3
            // 
            this.picBDecoders2Reg3.BackColor = System.Drawing.Color.Teal;
            this.picBDecoders2Reg3.Location = new System.Drawing.Point(208, 12);
            this.picBDecoders2Reg3.Name = "picBDecoders2Reg3";
            this.picBDecoders2Reg3.Size = new System.Drawing.Size(10, 56);
            this.picBDecoders2Reg3.TabIndex = 148;
            this.picBDecoders2Reg3.TabStop = false;
            // 
            // picBDecoders2Reg4
            // 
            this.picBDecoders2Reg4.BackColor = System.Drawing.Color.Teal;
            this.picBDecoders2Reg4.Location = new System.Drawing.Point(136, 5);
            this.picBDecoders2Reg4.Name = "picBDecoders2Reg4";
            this.picBDecoders2Reg4.Size = new System.Drawing.Size(82, 10);
            this.picBDecoders2Reg4.TabIndex = 149;
            this.picBDecoders2Reg4.TabStop = false;
            // 
            // picBDecoders2Reg5
            // 
            this.picBDecoders2Reg5.BackColor = System.Drawing.Color.Teal;
            this.picBDecoders2Reg5.Location = new System.Drawing.Point(136, 8);
            this.picBDecoders2Reg5.Name = "picBDecoders2Reg5";
            this.picBDecoders2Reg5.Size = new System.Drawing.Size(10, 8);
            this.picBDecoders2Reg5.TabIndex = 150;
            this.picBDecoders2Reg5.TabStop = false;
            // 
            // picBReg2Ac
            // 
            this.picBReg2Ac.BackColor = System.Drawing.Color.Teal;
            this.picBReg2Ac.Location = new System.Drawing.Point(72, 48);
            this.picBReg2Ac.Name = "picBReg2Ac";
            this.picBReg2Ac.Size = new System.Drawing.Size(48, 10);
            this.picBReg2Ac.TabIndex = 151;
            this.picBReg2Ac.TabStop = false;
            // 
            // picBReg2Sp
            // 
            this.picBReg2Sp.BackColor = System.Drawing.Color.Teal;
            this.picBReg2Sp.Location = new System.Drawing.Point(72, 72);
            this.picBReg2Sp.Name = "picBReg2Sp";
            this.picBReg2Sp.Size = new System.Drawing.Size(48, 10);
            this.picBReg2Sp.TabIndex = 152;
            this.picBReg2Sp.TabStop = false;
            // 
            // picBReg2Ir
            // 
            this.picBReg2Ir.BackColor = System.Drawing.Color.Teal;
            this.picBReg2Ir.Location = new System.Drawing.Point(72, 96);
            this.picBReg2Ir.Name = "picBReg2Ir";
            this.picBReg2Ir.Size = new System.Drawing.Size(48, 10);
            this.picBReg2Ir.TabIndex = 153;
            this.picBReg2Ir.TabStop = false;
            // 
            // picBReg2Tir
            // 
            this.picBReg2Tir.BackColor = System.Drawing.Color.Teal;
            this.picBReg2Tir.Location = new System.Drawing.Point(72, 120);
            this.picBReg2Tir.Name = "picBReg2Tir";
            this.picBReg2Tir.Size = new System.Drawing.Size(48, 10);
            this.picBReg2Tir.TabIndex = 154;
            this.picBReg2Tir.TabStop = false;
            // 
            // picBReg2Zero
            // 
            this.picBReg2Zero.BackColor = System.Drawing.Color.Teal;
            this.picBReg2Zero.Location = new System.Drawing.Point(72, 144);
            this.picBReg2Zero.Name = "picBReg2Zero";
            this.picBReg2Zero.Size = new System.Drawing.Size(48, 10);
            this.picBReg2Zero.TabIndex = 155;
            this.picBReg2Zero.TabStop = false;
            // 
            // picBReg2MaisUm
            // 
            this.picBReg2MaisUm.BackColor = System.Drawing.Color.Teal;
            this.picBReg2MaisUm.Location = new System.Drawing.Point(72, 168);
            this.picBReg2MaisUm.Name = "picBReg2MaisUm";
            this.picBReg2MaisUm.Size = new System.Drawing.Size(48, 10);
            this.picBReg2MaisUm.TabIndex = 156;
            this.picBReg2MaisUm.TabStop = false;
            // 
            // picBReg2MenosUm
            // 
            this.picBReg2MenosUm.BackColor = System.Drawing.Color.Teal;
            this.picBReg2MenosUm.Location = new System.Drawing.Point(72, 192);
            this.picBReg2MenosUm.Name = "picBReg2MenosUm";
            this.picBReg2MenosUm.Size = new System.Drawing.Size(48, 10);
            this.picBReg2MenosUm.TabIndex = 157;
            this.picBReg2MenosUm.TabStop = false;
            // 
            // picBReg2Amask
            // 
            this.picBReg2Amask.BackColor = System.Drawing.Color.Teal;
            this.picBReg2Amask.Location = new System.Drawing.Point(72, 216);
            this.picBReg2Amask.Name = "picBReg2Amask";
            this.picBReg2Amask.Size = new System.Drawing.Size(48, 10);
            this.picBReg2Amask.TabIndex = 158;
            this.picBReg2Amask.TabStop = false;
            // 
            // picBReg2Smask
            // 
            this.picBReg2Smask.BackColor = System.Drawing.Color.Teal;
            this.picBReg2Smask.Location = new System.Drawing.Point(72, 240);
            this.picBReg2Smask.Name = "picBReg2Smask";
            this.picBReg2Smask.Size = new System.Drawing.Size(48, 10);
            this.picBReg2Smask.TabIndex = 159;
            this.picBReg2Smask.TabStop = false;
            // 
            // picBReg2A
            // 
            this.picBReg2A.BackColor = System.Drawing.Color.Teal;
            this.picBReg2A.Location = new System.Drawing.Point(72, 264);
            this.picBReg2A.Name = "picBReg2A";
            this.picBReg2A.Size = new System.Drawing.Size(48, 10);
            this.picBReg2A.TabIndex = 160;
            this.picBReg2A.TabStop = false;
            // 
            // picBReg2B
            // 
            this.picBReg2B.BackColor = System.Drawing.Color.Teal;
            this.picBReg2B.Location = new System.Drawing.Point(72, 288);
            this.picBReg2B.Name = "picBReg2B";
            this.picBReg2B.Size = new System.Drawing.Size(48, 10);
            this.picBReg2B.TabIndex = 161;
            this.picBReg2B.TabStop = false;
            // 
            // picBReg2C
            // 
            this.picBReg2C.BackColor = System.Drawing.Color.Teal;
            this.picBReg2C.Location = new System.Drawing.Point(72, 312);
            this.picBReg2C.Name = "picBReg2C";
            this.picBReg2C.Size = new System.Drawing.Size(48, 10);
            this.picBReg2C.TabIndex = 162;
            this.picBReg2C.TabStop = false;
            // 
            // picBReg2D
            // 
            this.picBReg2D.BackColor = System.Drawing.Color.Teal;
            this.picBReg2D.Location = new System.Drawing.Point(72, 336);
            this.picBReg2D.Name = "picBReg2D";
            this.picBReg2D.Size = new System.Drawing.Size(48, 10);
            this.picBReg2D.TabIndex = 163;
            this.picBReg2D.TabStop = false;
            // 
            // picBReg2E
            // 
            this.picBReg2E.BackColor = System.Drawing.Color.Teal;
            this.picBReg2E.Location = new System.Drawing.Point(72, 360);
            this.picBReg2E.Name = "picBReg2E";
            this.picBReg2E.Size = new System.Drawing.Size(48, 10);
            this.picBReg2E.TabIndex = 164;
            this.picBReg2E.TabStop = false;
            // 
            // picBReg2F
            // 
            this.picBReg2F.BackColor = System.Drawing.Color.Teal;
            this.picBReg2F.Location = new System.Drawing.Point(72, 384);
            this.picBReg2F.Name = "picBReg2F";
            this.picBReg2F.Size = new System.Drawing.Size(48, 10);
            this.picBReg2F.TabIndex = 165;
            this.picBReg2F.TabStop = false;
            // 
            // picBDesloc2Reg1
            // 
            this.picBDesloc2Reg1.BackColor = System.Drawing.Color.Teal;
            this.picBDesloc2Reg1.Location = new System.Drawing.Point(160, 496);
            this.picBDesloc2Reg1.Name = "picBDesloc2Reg1";
            this.picBDesloc2Reg1.Size = new System.Drawing.Size(128, 10);
            this.picBDesloc2Reg1.TabIndex = 166;
            this.picBDesloc2Reg1.TabStop = false;
            // 
            // picBAlu2Shifter
            // 
            this.picBAlu2Shifter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.picBAlu2Shifter.Location = new System.Drawing.Point(315, 472);
            this.picBAlu2Shifter.Name = "picBAlu2Shifter";
            this.picBAlu2Shifter.Size = new System.Drawing.Size(10, 24);
            this.picBAlu2Shifter.TabIndex = 167;
            this.picBAlu2Shifter.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.ControlBox = true;
            this.Controls.Add(this.picMmux);
            this.Controls.Add(this.picMpc);
            this.Controls.Add(this.picIncrementador);
            this.Controls.Add(this.picMirAmux);
            this.Controls.Add(this.picBAlu2Shifter);
            this.Controls.Add(this.picBDesloc2Reg1);
            this.Controls.Add(this.picBReg2F);
            this.Controls.Add(this.picBReg2E);
            this.Controls.Add(this.picBReg2D);
            this.Controls.Add(this.picBReg2C);
            this.Controls.Add(this.picBReg2B);
            this.Controls.Add(this.picBReg2A);
            this.Controls.Add(this.picBReg2Smask);
            this.Controls.Add(this.picBReg2Amask);
            this.Controls.Add(this.picBReg2MenosUm);
            this.Controls.Add(this.picBReg2MaisUm);
            this.Controls.Add(this.picBReg2Zero);
            this.Controls.Add(this.picBReg2Tir);
            this.Controls.Add(this.picBReg2Ir);
            this.Controls.Add(this.picBReg2Sp);
            this.Controls.Add(this.picBReg2Ac);
            this.Controls.Add(this.picBDecoders2Reg5);
            this.Controls.Add(this.picBDecoders2Reg4);
            this.Controls.Add(this.picBDecoders2Reg3);
            this.Controls.Add(this.picBDecoders2Reg2);
            this.Controls.Add(this.picBDecoders2Reg1);
            this.Controls.Add(this.picBReg2Pc);
            this.Controls.Add(this.picBDesloc2Reg4);
            this.Controls.Add(this.picBDesloc2Reg3);
            this.Controls.Add(this.picBDesloc2Reg2);
            this.Controls.Add(this.picBLms2Mpc3);
            this.Controls.Add(this.picBLms2Mpc2);
            this.Controls.Add(this.picBLms2Mpc1);
            this.Controls.Add(this.picBAmux2Alu);
            this.Controls.Add(this.picBMemControle2Mir);
            this.Controls.Add(this.picBMpc2Incrementador);
            this.Controls.Add(this.picBIncrem2Mmux1);
            this.Controls.Add(this.picBIncrem2Mmux3);
            this.Controls.Add(this.picBIncrem2Mmux2);
            this.Controls.Add(this.picMemControle);
            this.Controls.Add(this.picBMpc2MemControle);
            this.Controls.Add(this.picBMirWr2Mbr3);
            this.Controls.Add(this.picBMirWr2Mbr2);
            this.Controls.Add(this.picBMirRd2Mbr3);
            this.Controls.Add(this.picBMirRd2Mbr2);
            this.Controls.Add(this.picBMirWr2Mbr1);
            this.Controls.Add(this.picBMirRd2Mbr1);
            this.Controls.Add(this.picBMirEnc2DecodC1);
            this.Controls.Add(this.picBMirMar2Mar2);
            this.Controls.Add(this.picBMirA2DecodA1);
            this.Controls.Add(this.picBMirA2DecodA2);
            this.Controls.Add(this.picBMirA2DecodA3);
            this.Controls.Add(this.picBMirA2DecodA6);
            this.Controls.Add(this.picBMirA2DecodA5);
            this.Controls.Add(this.picBMirA2DecodA4);
            this.Controls.Add(this.picBMirB2DecodB6);
            this.Controls.Add(this.picBMirB2DecodB5);
            this.Controls.Add(this.picBMirB2DecodB4);
            this.Controls.Add(this.picBMirB2DecodB3);
            this.Controls.Add(this.picBMirB2DecodB2);
            this.Controls.Add(this.picBMirB2DecodB1);
            this.Controls.Add(this.picBMirC2DecodC4);
            this.Controls.Add(this.picBMirC2DecodC3);
            this.Controls.Add(this.picBMirC2DecodC2);
            this.Controls.Add(this.picBMirC2DecodC1);
            this.Controls.Add(this.picBMirEnc2DecodC4);
            this.Controls.Add(this.picBMirEnc2DecodC3);
            this.Controls.Add(this.picBMirEnc2DecodC2);
            this.Controls.Add(this.picBMirMar2Mar1);
            this.Controls.Add(this.picBMmux2Mpc);
            this.Controls.Add(this.picBAddr2Mmux3);
            this.Controls.Add(this.picBAddr2Mmux2);
            this.Controls.Add(this.picBAddr2Mmux1);
            this.Controls.Add(this.picBMirMar2Mar4);
            this.Controls.Add(this.picBMirMar2Mar3);
            this.Controls.Add(this.picBMirMbr2Mbr2);
            this.Controls.Add(this.picBMirMbr2Mbr1);
            this.Controls.Add(this.picBMirMbr2Mbr3);
            this.Controls.Add(this.picBMirSh2Desloc2);
            this.Controls.Add(this.picBMirSh2Desloc1);
            this.Controls.Add(this.picBAluZ2LMS);
            this.Controls.Add(this.picBAluN2LMS);
            this.Controls.Add(this.picBMirAlu2Alu2);
            this.Controls.Add(this.picBMirAlu2Alu1);
            this.Controls.Add(this.picBMirCond2Lms2);
            this.Controls.Add(this.picBMirCond2Lms1);
            this.Controls.Add(this.picBMirAmux2Amux2);
            this.Controls.Add(this.picBMirAmux2Amux1);
            this.Controls.Add(this.picBDecodA2Reg1);
            this.Controls.Add(this.picBDecodB2Reg1);
            this.Controls.Add(this.picBDecodC2Reg1);
            this.Controls.Add(this.picMirAddr);
            this.Controls.Add(this.picMirA);
            this.Controls.Add(this.picMirB);
            this.Controls.Add(this.picMirC);
            this.Controls.Add(this.picMirEnc);
            this.Controls.Add(this.picMirWr);
            this.Controls.Add(this.picMirRd);
            this.Controls.Add(this.picMirMar);
            this.Controls.Add(this.picMirMbr);
            this.Controls.Add(this.picMirSh);
            this.Controls.Add(this.picMirAlu);
            this.Controls.Add(this.picMirCond);
            this.Controls.Add(this.picBF2Latch);
            this.Controls.Add(this.picBE2Latch);
            this.Controls.Add(this.picBD2Latch);
            this.Controls.Add(this.picBC2Latch);
            this.Controls.Add(this.picBB2Latch);
            this.Controls.Add(this.picBA2Latch);
            this.Controls.Add(this.picBSmask2Latch);
            this.Controls.Add(this.picBAmask2Latch);
            this.Controls.Add(this.picBMenosUm2Latch);
            this.Controls.Add(this.picBMaisUm2Latch);
            this.Controls.Add(this.picBZero2Latch);
            this.Controls.Add(this.picBTir2Latch);
            this.Controls.Add(this.picBIr2Latch);
            this.Controls.Add(this.picBSp2Latch);
            this.Controls.Add(this.picBAc2Latch);
            this.Controls.Add(this.picBPc2Latch);
            this.Controls.Add(this.picBLatchB2Mar3);
            this.Controls.Add(this.picBLatchB2Mar2);
            this.Controls.Add(this.picBLatchB2Mar1);
            this.Controls.Add(this.picBMbr2Amux1);
            this.Controls.Add(this.picBMbr2Amux2);
            this.Controls.Add(this.picBMbr2Amux3);
            this.Controls.Add(this.picBMbr2Amux4);
            this.Controls.Add(this.picBLatchB2Alu);
            this.Controls.Add(this.picBLatchA2Alu);
            this.Controls.Add(this.picBReg2LatchB2);
            this.Controls.Add(this.picBReg2LatchB1);
            this.Controls.Add(this.picBReg2LatchA2);
            this.Controls.Add(this.picBReg2LatchA1);
            this.Controls.Add(this.picBDesloc2Mbr);
            this.Controls.Add(this.picBReg2Latch);
            this.Controls.Add(this.picAlu);
            this.Controls.Add(this.picLogMicSeq);
            this.Controls.Add(this.picShifter);
            this.Controls.Add(this.picAmux);
            this.Controls.Add(this.picLatchB);
            this.Controls.Add(this.picLatchA);
            this.Controls.Add(this.picDecodA);
            this.Controls.Add(this.picDecodB);
            this.Controls.Add(this.picDecodC);
            this.Controls.Add(this.picRegF);
            this.Controls.Add(this.picRegE);
            this.Controls.Add(this.picRegD);
            this.Controls.Add(this.picRegC);
            this.Controls.Add(this.picRegB);
            this.Controls.Add(this.picRegA);
            this.Controls.Add(this.picRegSmask);
            this.Controls.Add(this.picRegAmask);
            this.Controls.Add(this.picRegMenosUm);
            this.Controls.Add(this.picRegMaisUm);
            this.Controls.Add(this.picRegZero);
            this.Controls.Add(this.picRegTir);
            this.Controls.Add(this.picRegIr);
            this.Controls.Add(this.picRegSp);
            this.Controls.Add(this.picRegAc);
            this.Controls.Add(this.picRegPc);
            this.Controls.Add(this.picMar);
            this.Controls.Add(this.picMbr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimMAC";
            this.ResumeLayout(false);

        }
        #endregion

        /*
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint (e);

			Rectangle r = new Rectangle(this.Location,this.Size);

			System.Drawing.Drawing2D.LinearGradientBrush l =
				new System.Drawing.Drawing2D.LinearGradientBrush(r,
					Color.White, Color.Black,System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);

			e.Graphics.FillRectangle(l,r);
		}
		*/
    }
}
