using System.Windows.Forms;

namespace Interface
{
    /// <summary>
    /// Summary description for frmRegs.
    /// </summary>
    public class frmRegs : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtSMASK;
        private System.Windows.Forms.TextBox txtAMASK;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblSMASK;
        private System.Windows.Forms.Label lblAMASK;
        private System.Windows.Forms.TextBox txtMe1;
        private System.Windows.Forms.Label lblMe1;
        private System.Windows.Forms.TextBox txtMa1;
        private System.Windows.Forms.Label lblMa1;
        private System.Windows.Forms.TextBox txt0;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.TextBox txtTIR;
        private System.Windows.Forms.Label lblTIR;
        private System.Windows.Forms.TextBox txtIR;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblD;
        private Machine.Machine _machine;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmRegs(Machine.Machine machine)
        {
            _machine = machine;
            //
            // Required for Windows Form Designer support
            //
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
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtSMASK = new System.Windows.Forms.TextBox();
            this.txtAMASK = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblSMASK = new System.Windows.Forms.Label();
            this.lblAMASK = new System.Windows.Forms.Label();
            this.txtMe1 = new System.Windows.Forms.TextBox();
            this.lblMe1 = new System.Windows.Forms.Label();
            this.txtMa1 = new System.Windows.Forms.TextBox();
            this.lblMa1 = new System.Windows.Forms.Label();
            this.txt0 = new System.Windows.Forms.TextBox();
            this.lbl0 = new System.Windows.Forms.Label();
            this.txtTIR = new System.Windows.Forms.TextBox();
            this.lblTIR = new System.Windows.Forms.Label();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.lblIR = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.lblSP = new System.Windows.Forms.Label();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.lblAC = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.lblPC = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblF = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtC.Location = new System.Drawing.Point(48, 216);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(122, 20);
            this.txtC.TabIndex = 52;
            this.txtC.Text = "";
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtB.Location = new System.Drawing.Point(48, 198);
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(122, 20);
            this.txtB.TabIndex = 51;
            this.txtB.Text = "";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtA.Location = new System.Drawing.Point(48, 180);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(122, 20);
            this.txtA.TabIndex = 50;
            this.txtA.Text = "";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSMASK
            // 
            this.txtSMASK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtSMASK.Location = new System.Drawing.Point(48, 162);
            this.txtSMASK.Name = "txtSMASK";
            this.txtSMASK.ReadOnly = true;
            this.txtSMASK.Size = new System.Drawing.Size(122, 20);
            this.txtSMASK.TabIndex = 49;
            this.txtSMASK.Text = "";
            this.txtSMASK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAMASK
            // 
            this.txtAMASK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtAMASK.Location = new System.Drawing.Point(48, 144);
            this.txtAMASK.Name = "txtAMASK";
            this.txtAMASK.ReadOnly = true;
            this.txtAMASK.Size = new System.Drawing.Size(122, 20);
            this.txtAMASK.TabIndex = 48;
            this.txtAMASK.Text = "";
            this.txtAMASK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblC
            // 
            this.lblC.BackColor = System.Drawing.Color.Lavender;
            this.lblC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.Black;
            this.lblC.Location = new System.Drawing.Point(2, 216);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(48, 20);
            this.lblC.TabIndex = 47;
            this.lblC.Text = "C";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.BackColor = System.Drawing.Color.Lavender;
            this.lblB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.Black;
            this.lblB.Location = new System.Drawing.Point(2, 198);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(48, 20);
            this.lblB.TabIndex = 46;
            this.lblB.Text = "B";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            this.lblA.BackColor = System.Drawing.Color.Lavender;
            this.lblA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Black;
            this.lblA.Location = new System.Drawing.Point(2, 180);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(48, 20);
            this.lblA.TabIndex = 45;
            this.lblA.Text = "A";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSMASK
            // 
            this.lblSMASK.BackColor = System.Drawing.Color.Lavender;
            this.lblSMASK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSMASK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblSMASK.ForeColor = System.Drawing.Color.Black;
            this.lblSMASK.Location = new System.Drawing.Point(2, 162);
            this.lblSMASK.Name = "lblSMASK";
            this.lblSMASK.Size = new System.Drawing.Size(48, 20);
            this.lblSMASK.TabIndex = 44;
            this.lblSMASK.Text = "SMASK";
            this.lblSMASK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAMASK
            // 
            this.lblAMASK.BackColor = System.Drawing.Color.Lavender;
            this.lblAMASK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAMASK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblAMASK.ForeColor = System.Drawing.Color.Black;
            this.lblAMASK.Location = new System.Drawing.Point(2, 144);
            this.lblAMASK.Name = "lblAMASK";
            this.lblAMASK.Size = new System.Drawing.Size(48, 20);
            this.lblAMASK.TabIndex = 43;
            this.lblAMASK.Text = "AMASK";
            this.lblAMASK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMe1
            // 
            this.txtMe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtMe1.Location = new System.Drawing.Point(48, 126);
            this.txtMe1.Name = "txtMe1";
            this.txtMe1.ReadOnly = true;
            this.txtMe1.Size = new System.Drawing.Size(122, 20);
            this.txtMe1.TabIndex = 42;
            this.txtMe1.Text = "";
            this.txtMe1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMe1
            // 
            this.lblMe1.BackColor = System.Drawing.Color.Lavender;
            this.lblMe1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblMe1.ForeColor = System.Drawing.Color.Black;
            this.lblMe1.Location = new System.Drawing.Point(2, 126);
            this.lblMe1.Name = "lblMe1";
            this.lblMe1.Size = new System.Drawing.Size(48, 20);
            this.lblMe1.TabIndex = 41;
            this.lblMe1.Text = "-1";
            this.lblMe1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMa1
            // 
            this.txtMa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtMa1.Location = new System.Drawing.Point(48, 108);
            this.txtMa1.Name = "txtMa1";
            this.txtMa1.ReadOnly = true;
            this.txtMa1.Size = new System.Drawing.Size(122, 20);
            this.txtMa1.TabIndex = 40;
            this.txtMa1.Text = "";
            this.txtMa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMa1
            // 
            this.lblMa1.BackColor = System.Drawing.Color.Lavender;
            this.lblMa1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblMa1.ForeColor = System.Drawing.Color.Black;
            this.lblMa1.Location = new System.Drawing.Point(2, 108);
            this.lblMa1.Name = "lblMa1";
            this.lblMa1.Size = new System.Drawing.Size(48, 20);
            this.lblMa1.TabIndex = 39;
            this.lblMa1.Text = "+1";
            this.lblMa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt0
            // 
            this.txt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txt0.Location = new System.Drawing.Point(48, 90);
            this.txt0.Name = "txt0";
            this.txt0.ReadOnly = true;
            this.txt0.Size = new System.Drawing.Size(122, 20);
            this.txt0.TabIndex = 38;
            this.txt0.Text = "";
            this.txt0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl0
            // 
            this.lbl0.BackColor = System.Drawing.Color.Lavender;
            this.lbl0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lbl0.ForeColor = System.Drawing.Color.Black;
            this.lbl0.Location = new System.Drawing.Point(2, 90);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(48, 20);
            this.lbl0.TabIndex = 37;
            this.lbl0.Text = "0";
            this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTIR
            // 
            this.txtTIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtTIR.Location = new System.Drawing.Point(48, 72);
            this.txtTIR.Name = "txtTIR";
            this.txtTIR.ReadOnly = true;
            this.txtTIR.Size = new System.Drawing.Size(122, 20);
            this.txtTIR.TabIndex = 36;
            this.txtTIR.Text = "";
            this.txtTIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTIR
            // 
            this.lblTIR.BackColor = System.Drawing.Color.Lavender;
            this.lblTIR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblTIR.ForeColor = System.Drawing.Color.Black;
            this.lblTIR.Location = new System.Drawing.Point(2, 72);
            this.lblTIR.Name = "lblTIR";
            this.lblTIR.Size = new System.Drawing.Size(48, 20);
            this.lblTIR.TabIndex = 35;
            this.lblTIR.Text = "TIR";
            this.lblTIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIR
            // 
            this.txtIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtIR.Location = new System.Drawing.Point(48, 54);
            this.txtIR.Name = "txtIR";
            this.txtIR.ReadOnly = true;
            this.txtIR.Size = new System.Drawing.Size(122, 20);
            this.txtIR.TabIndex = 34;
            this.txtIR.Text = "";
            this.txtIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIR
            // 
            this.lblIR.BackColor = System.Drawing.Color.Lavender;
            this.lblIR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblIR.ForeColor = System.Drawing.Color.Black;
            this.lblIR.Location = new System.Drawing.Point(2, 54);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(48, 20);
            this.lblIR.TabIndex = 33;
            this.lblIR.Text = "IR";
            this.lblIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSP
            // 
            this.txtSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtSP.Location = new System.Drawing.Point(48, 36);
            this.txtSP.Name = "txtSP";
            this.txtSP.ReadOnly = true;
            this.txtSP.Size = new System.Drawing.Size(122, 20);
            this.txtSP.TabIndex = 32;
            this.txtSP.Text = "";
            this.txtSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSP
            // 
            this.lblSP.BackColor = System.Drawing.Color.Lavender;
            this.lblSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblSP.ForeColor = System.Drawing.Color.Black;
            this.lblSP.Location = new System.Drawing.Point(2, 36);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(48, 20);
            this.lblSP.TabIndex = 31;
            this.lblSP.Text = "SP";
            this.lblSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAC
            // 
            this.txtAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtAC.Location = new System.Drawing.Point(48, 18);
            this.txtAC.Name = "txtAC";
            this.txtAC.ReadOnly = true;
            this.txtAC.Size = new System.Drawing.Size(122, 20);
            this.txtAC.TabIndex = 30;
            this.txtAC.Text = "";
            this.txtAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAC
            // 
            this.lblAC.BackColor = System.Drawing.Color.Lavender;
            this.lblAC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblAC.ForeColor = System.Drawing.Color.Black;
            this.lblAC.Location = new System.Drawing.Point(2, 18);
            this.lblAC.Name = "lblAC";
            this.lblAC.Size = new System.Drawing.Size(48, 20);
            this.lblAC.TabIndex = 29;
            this.lblAC.Text = "AC";
            this.lblAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPC
            // 
            this.txtPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtPC.Location = new System.Drawing.Point(48, 2);
            this.txtPC.Name = "txtPC";
            this.txtPC.ReadOnly = true;
            this.txtPC.Size = new System.Drawing.Size(122, 20);
            this.txtPC.TabIndex = 28;
            this.txtPC.Text = "";
            this.txtPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPC
            // 
            this.lblPC.BackColor = System.Drawing.Color.Lavender;
            this.lblPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblPC.ForeColor = System.Drawing.Color.Black;
            this.lblPC.Location = new System.Drawing.Point(2, 2);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(48, 20);
            this.lblPC.TabIndex = 27;
            this.lblPC.Text = "PC";
            this.lblPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtF
            // 
            this.txtF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtF.Location = new System.Drawing.Point(48, 270);
            this.txtF.Name = "txtF";
            this.txtF.ReadOnly = true;
            this.txtF.Size = new System.Drawing.Size(122, 20);
            this.txtF.TabIndex = 58;
            this.txtF.Text = "";
            this.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtE.Location = new System.Drawing.Point(48, 252);
            this.txtE.Name = "txtE";
            this.txtE.ReadOnly = true;
            this.txtE.Size = new System.Drawing.Size(122, 20);
            this.txtE.TabIndex = 57;
            this.txtE.Text = "";
            this.txtE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtD.Location = new System.Drawing.Point(48, 234);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(122, 20);
            this.txtD.TabIndex = 56;
            this.txtD.Text = "";
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblF
            // 
            this.lblF.BackColor = System.Drawing.Color.Lavender;
            this.lblF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblF.ForeColor = System.Drawing.Color.Black;
            this.lblF.Location = new System.Drawing.Point(2, 270);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(48, 20);
            this.lblF.TabIndex = 55;
            this.lblF.Text = "F";
            this.lblF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblE
            // 
            this.lblE.BackColor = System.Drawing.Color.Lavender;
            this.lblE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblE.ForeColor = System.Drawing.Color.Black;
            this.lblE.Location = new System.Drawing.Point(2, 252);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(48, 20);
            this.lblE.TabIndex = 54;
            this.lblE.Text = "E";
            this.lblE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblD
            // 
            this.lblD.BackColor = System.Drawing.Color.Lavender;
            this.lblD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblD.ForeColor = System.Drawing.Color.Black;
            this.lblD.Location = new System.Drawing.Point(2, 234);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(48, 20);
            this.lblD.TabIndex = 53;
            this.lblD.Text = "D";
            this.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegs
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(170, 290);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtSMASK);
            this.Controls.Add(this.txtAMASK);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblSMASK);
            this.Controls.Add(this.lblAMASK);
            this.Controls.Add(this.txtMe1);
            this.Controls.Add(this.lblMe1);
            this.Controls.Add(this.txtMa1);
            this.Controls.Add(this.lblMa1);
            this.Controls.Add(this.txt0);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.txtTIR);
            this.Controls.Add(this.lblTIR);
            this.Controls.Add(this.txtIR);
            this.Controls.Add(this.lblIR);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.lblSP);
            this.Controls.Add(this.txtAC);
            this.Controls.Add(this.lblAC);
            this.Controls.Add(this.txtPC);
            this.Controls.Add(this.lblPC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(810, 350);
            this.Name = "frmRegs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registers";
            this.ResumeLayout(false);

        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            this.txt0.Text = Machine.Machine.TracksToString(_machine.regs.Zero.Value);
            this.txtA.Text = Machine.Machine.TracksToString(_machine.regs.A.Value);
            this.txtAC.Text = Machine.Machine.TracksToString(_machine.regs.AC.Value);
            this.txtAMASK.Text = Machine.Machine.TracksToString(_machine.regs.AMask.Value);
            this.txtB.Text = Machine.Machine.TracksToString(_machine.regs.B.Value);
            this.txtC.Text = Machine.Machine.TracksToString(_machine.regs.C.Value);
            this.txtD.Text = Machine.Machine.TracksToString(_machine.regs.D.Value);
            this.txtE.Text = Machine.Machine.TracksToString(_machine.regs.E.Value);
            this.txtF.Text = Machine.Machine.TracksToString(_machine.regs.F.Value);
            this.txtIR.Text = Machine.Machine.TracksToString(_machine.regs.IR.Value);
            this.txtMa1.Text = Machine.Machine.TracksToString(_machine.regs.MaisUm.Value);
            this.txtMe1.Text = Machine.Machine.TracksToString(_machine.regs.MenosUm.Value);
            this.txtPC.Text = Machine.Machine.TracksToString(_machine.regs.PC.Value);
            this.txtSMASK.Text = Machine.Machine.TracksToString(_machine.regs.SMask.Value);
            this.txtSP.Text = Machine.Machine.TracksToString(_machine.regs.SP.Value);
            this.txtTIR.Text = Machine.Machine.TracksToString(_machine.regs.TIR.Value);
            base.OnPaint(e);
        }

    }
}
