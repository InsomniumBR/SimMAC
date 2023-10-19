using System.Windows.Forms;

namespace Interface
{
    /// <summary>
    /// Summary description for frmMir.
    /// </summary>
    public class frmMir : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label lblAMUX;
        private System.Windows.Forms.TextBox txtAMUX;
        private System.Windows.Forms.TextBox txtCOND;
        private System.Windows.Forms.Label lblCOND;
        private System.Windows.Forms.TextBox txtALU;
        private System.Windows.Forms.Label lblALU;
        private System.Windows.Forms.TextBox txtSH;
        private System.Windows.Forms.Label lblSH;
        private System.Windows.Forms.TextBox txtWR;
        private System.Windows.Forms.Label lblWR;
        private System.Windows.Forms.TextBox txtRD;
        private System.Windows.Forms.Label lblRD;
        private System.Windows.Forms.TextBox txtMAR;
        private System.Windows.Forms.Label lblMAR;
        private System.Windows.Forms.TextBox txtMBR;
        private System.Windows.Forms.Label lblMBR;
        private System.Windows.Forms.Label lblADDR;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblENC;
        private System.Windows.Forms.TextBox txtENC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtADDR;
        private Machine.Machine _machine;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmMir(Machine.Machine machine)
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
            this.lblAMUX = new System.Windows.Forms.Label();
            this.txtAMUX = new System.Windows.Forms.TextBox();
            this.txtCOND = new System.Windows.Forms.TextBox();
            this.lblCOND = new System.Windows.Forms.Label();
            this.txtALU = new System.Windows.Forms.TextBox();
            this.lblALU = new System.Windows.Forms.Label();
            this.txtSH = new System.Windows.Forms.TextBox();
            this.lblSH = new System.Windows.Forms.Label();
            this.txtWR = new System.Windows.Forms.TextBox();
            this.lblWR = new System.Windows.Forms.Label();
            this.txtRD = new System.Windows.Forms.TextBox();
            this.lblRD = new System.Windows.Forms.Label();
            this.txtMAR = new System.Windows.Forms.TextBox();
            this.lblMAR = new System.Windows.Forms.Label();
            this.txtMBR = new System.Windows.Forms.TextBox();
            this.lblMBR = new System.Windows.Forms.Label();
            this.lblADDR = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblENC = new System.Windows.Forms.Label();
            this.txtENC = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtADDR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAMUX
            // 
            this.lblAMUX.BackColor = System.Drawing.Color.Lavender;
            this.lblAMUX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAMUX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblAMUX.ForeColor = System.Drawing.Color.Black;
            this.lblAMUX.Location = new System.Drawing.Point(0, 0);
            this.lblAMUX.Name = "lblAMUX";
            this.lblAMUX.Size = new System.Drawing.Size(48, 20);
            this.lblAMUX.TabIndex = 0;
            this.lblAMUX.Text = "AMUX";
            this.lblAMUX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAMUX
            // 
            this.txtAMUX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtAMUX.Location = new System.Drawing.Point(48, 0);
            this.txtAMUX.MaxLength = 8;
            this.txtAMUX.Name = "txtAMUX";
            this.txtAMUX.ReadOnly = true;
            this.txtAMUX.Size = new System.Drawing.Size(64, 20);
            this.txtAMUX.TabIndex = 2;
            this.txtAMUX.Text = "";
            this.txtAMUX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCOND
            // 
            this.txtCOND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtCOND.Location = new System.Drawing.Point(48, 16);
            this.txtCOND.MaxLength = 8;
            this.txtCOND.Name = "txtCOND";
            this.txtCOND.ReadOnly = true;
            this.txtCOND.Size = new System.Drawing.Size(64, 20);
            this.txtCOND.TabIndex = 4;
            this.txtCOND.Text = "";
            this.txtCOND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCOND
            // 
            this.lblCOND.BackColor = System.Drawing.Color.Lavender;
            this.lblCOND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCOND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblCOND.ForeColor = System.Drawing.Color.Black;
            this.lblCOND.Location = new System.Drawing.Point(0, 16);
            this.lblCOND.Name = "lblCOND";
            this.lblCOND.Size = new System.Drawing.Size(48, 20);
            this.lblCOND.TabIndex = 3;
            this.lblCOND.Text = "COND";
            this.lblCOND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtALU
            // 
            this.txtALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtALU.Location = new System.Drawing.Point(48, 34);
            this.txtALU.MaxLength = 8;
            this.txtALU.Name = "txtALU";
            this.txtALU.ReadOnly = true;
            this.txtALU.Size = new System.Drawing.Size(64, 20);
            this.txtALU.TabIndex = 6;
            this.txtALU.Text = "";
            this.txtALU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblALU
            // 
            this.lblALU.BackColor = System.Drawing.Color.Lavender;
            this.lblALU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblALU.ForeColor = System.Drawing.Color.Black;
            this.lblALU.Location = new System.Drawing.Point(0, 34);
            this.lblALU.Name = "lblALU";
            this.lblALU.Size = new System.Drawing.Size(48, 20);
            this.lblALU.TabIndex = 5;
            this.lblALU.Text = "ALU";
            this.lblALU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSH
            // 
            this.txtSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtSH.Location = new System.Drawing.Point(48, 52);
            this.txtSH.MaxLength = 8;
            this.txtSH.Name = "txtSH";
            this.txtSH.ReadOnly = true;
            this.txtSH.Size = new System.Drawing.Size(64, 20);
            this.txtSH.TabIndex = 8;
            this.txtSH.Text = "";
            this.txtSH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSH
            // 
            this.lblSH.BackColor = System.Drawing.Color.Lavender;
            this.lblSH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblSH.ForeColor = System.Drawing.Color.Black;
            this.lblSH.Location = new System.Drawing.Point(0, 52);
            this.lblSH.Name = "lblSH";
            this.lblSH.Size = new System.Drawing.Size(48, 20);
            this.lblSH.TabIndex = 7;
            this.lblSH.Text = "SH";
            this.lblSH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWR
            // 
            this.txtWR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtWR.Location = new System.Drawing.Point(48, 124);
            this.txtWR.MaxLength = 8;
            this.txtWR.Name = "txtWR";
            this.txtWR.ReadOnly = true;
            this.txtWR.Size = new System.Drawing.Size(64, 20);
            this.txtWR.TabIndex = 16;
            this.txtWR.Text = "";
            this.txtWR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWR
            // 
            this.lblWR.BackColor = System.Drawing.Color.Lavender;
            this.lblWR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblWR.ForeColor = System.Drawing.Color.Black;
            this.lblWR.Location = new System.Drawing.Point(0, 124);
            this.lblWR.Name = "lblWR";
            this.lblWR.Size = new System.Drawing.Size(48, 20);
            this.lblWR.TabIndex = 15;
            this.lblWR.Text = "WR";
            this.lblWR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRD
            // 
            this.txtRD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtRD.Location = new System.Drawing.Point(48, 106);
            this.txtRD.MaxLength = 8;
            this.txtRD.Name = "txtRD";
            this.txtRD.ReadOnly = true;
            this.txtRD.Size = new System.Drawing.Size(64, 20);
            this.txtRD.TabIndex = 14;
            this.txtRD.Text = "";
            this.txtRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRD
            // 
            this.lblRD.BackColor = System.Drawing.Color.Lavender;
            this.lblRD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblRD.ForeColor = System.Drawing.Color.Black;
            this.lblRD.Location = new System.Drawing.Point(0, 106);
            this.lblRD.Name = "lblRD";
            this.lblRD.Size = new System.Drawing.Size(48, 20);
            this.lblRD.TabIndex = 13;
            this.lblRD.Text = "RD";
            this.lblRD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMAR
            // 
            this.txtMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtMAR.Location = new System.Drawing.Point(48, 88);
            this.txtMAR.MaxLength = 8;
            this.txtMAR.Name = "txtMAR";
            this.txtMAR.ReadOnly = true;
            this.txtMAR.Size = new System.Drawing.Size(64, 20);
            this.txtMAR.TabIndex = 12;
            this.txtMAR.Text = "";
            this.txtMAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMAR
            // 
            this.lblMAR.BackColor = System.Drawing.Color.Lavender;
            this.lblMAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblMAR.ForeColor = System.Drawing.Color.Black;
            this.lblMAR.Location = new System.Drawing.Point(0, 88);
            this.lblMAR.Name = "lblMAR";
            this.lblMAR.Size = new System.Drawing.Size(48, 20);
            this.lblMAR.TabIndex = 11;
            this.lblMAR.Text = "MAR";
            this.lblMAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMBR
            // 
            this.txtMBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtMBR.Location = new System.Drawing.Point(48, 70);
            this.txtMBR.MaxLength = 8;
            this.txtMBR.Name = "txtMBR";
            this.txtMBR.ReadOnly = true;
            this.txtMBR.Size = new System.Drawing.Size(64, 20);
            this.txtMBR.TabIndex = 10;
            this.txtMBR.Text = "";
            this.txtMBR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMBR
            // 
            this.lblMBR.BackColor = System.Drawing.Color.Lavender;
            this.lblMBR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblMBR.ForeColor = System.Drawing.Color.Black;
            this.lblMBR.Location = new System.Drawing.Point(0, 70);
            this.lblMBR.Name = "lblMBR";
            this.lblMBR.Size = new System.Drawing.Size(48, 20);
            this.lblMBR.TabIndex = 9;
            this.lblMBR.Text = "MBR";
            this.lblMBR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblADDR
            // 
            this.lblADDR.BackColor = System.Drawing.Color.Lavender;
            this.lblADDR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblADDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblADDR.ForeColor = System.Drawing.Color.Black;
            this.lblADDR.Location = new System.Drawing.Point(0, 214);
            this.lblADDR.Name = "lblADDR";
            this.lblADDR.Size = new System.Drawing.Size(48, 20);
            this.lblADDR.TabIndex = 21;
            this.lblADDR.Text = "ADDR";
            this.lblADDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            this.lblA.BackColor = System.Drawing.Color.Lavender;
            this.lblA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Black;
            this.lblA.Location = new System.Drawing.Point(0, 196);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(48, 20);
            this.lblA.TabIndex = 20;
            this.lblA.Text = "A";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.BackColor = System.Drawing.Color.Lavender;
            this.lblB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.Black;
            this.lblB.Location = new System.Drawing.Point(0, 178);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(48, 20);
            this.lblB.TabIndex = 19;
            this.lblB.Text = "B";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblC
            // 
            this.lblC.BackColor = System.Drawing.Color.Lavender;
            this.lblC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.Black;
            this.lblC.Location = new System.Drawing.Point(0, 160);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(48, 20);
            this.lblC.TabIndex = 18;
            this.lblC.Text = "C";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblENC
            // 
            this.lblENC.BackColor = System.Drawing.Color.Lavender;
            this.lblENC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblENC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblENC.ForeColor = System.Drawing.Color.Black;
            this.lblENC.Location = new System.Drawing.Point(0, 142);
            this.lblENC.Name = "lblENC";
            this.lblENC.Size = new System.Drawing.Size(48, 20);
            this.lblENC.TabIndex = 17;
            this.lblENC.Text = "ENC";
            this.lblENC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtENC
            // 
            this.txtENC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtENC.Location = new System.Drawing.Point(48, 142);
            this.txtENC.MaxLength = 8;
            this.txtENC.Name = "txtENC";
            this.txtENC.ReadOnly = true;
            this.txtENC.Size = new System.Drawing.Size(64, 20);
            this.txtENC.TabIndex = 22;
            this.txtENC.Text = "";
            this.txtENC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtC.Location = new System.Drawing.Point(48, 160);
            this.txtC.MaxLength = 8;
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(64, 20);
            this.txtC.TabIndex = 23;
            this.txtC.Text = "";
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtB.Location = new System.Drawing.Point(48, 178);
            this.txtB.MaxLength = 8;
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(64, 20);
            this.txtB.TabIndex = 24;
            this.txtB.Text = "";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtA.Location = new System.Drawing.Point(48, 196);
            this.txtA.MaxLength = 8;
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(64, 20);
            this.txtA.TabIndex = 25;
            this.txtA.Text = "";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtADDR
            // 
            this.txtADDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtADDR.Location = new System.Drawing.Point(48, 214);
            this.txtADDR.MaxLength = 8;
            this.txtADDR.Name = "txtADDR";
            this.txtADDR.ReadOnly = true;
            this.txtADDR.Size = new System.Drawing.Size(64, 20);
            this.txtADDR.TabIndex = 26;
            this.txtADDR.Text = "";
            this.txtADDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmMir
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(110, 232);
            this.Controls.Add(this.txtADDR);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtENC);
            this.Controls.Add(this.lblADDR);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblENC);
            this.Controls.Add(this.txtWR);
            this.Controls.Add(this.lblWR);
            this.Controls.Add(this.txtRD);
            this.Controls.Add(this.lblRD);
            this.Controls.Add(this.txtMAR);
            this.Controls.Add(this.lblMAR);
            this.Controls.Add(this.txtMBR);
            this.Controls.Add(this.lblMBR);
            this.Controls.Add(this.txtSH);
            this.Controls.Add(this.lblSH);
            this.Controls.Add(this.txtALU);
            this.Controls.Add(this.lblALU);
            this.Controls.Add(this.txtCOND);
            this.Controls.Add(this.lblCOND);
            this.Controls.Add(this.txtAMUX);
            this.Controls.Add(this.lblAMUX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(560, 320);
            this.Name = "frmMir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mir";
            this.ResumeLayout(false);

        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            this.txtA.Text = Machine.Machine.TracksToString(_machine.mir.A.Bits);
            this.txtADDR.Text = Machine.Machine.TracksToString(_machine.mir.ADDR.Bits);
            this.txtALU.Text = Machine.Machine.TracksToString(_machine.mir.ALU.Bits);
            this.txtAMUX.Text = Machine.Machine.TracksToString(_machine.mir.AMUX.Bits);
            this.txtB.Text = Machine.Machine.TracksToString(_machine.mir.B.Bits);
            this.txtC.Text = Machine.Machine.TracksToString(_machine.mir.C.Bits);
            this.txtCOND.Text = Machine.Machine.TracksToString(_machine.mir.COND.Bits);
            this.txtENC.Text = Machine.Machine.TracksToString(_machine.mir.ENC.Bits);
            this.txtMAR.Text = Machine.Machine.TracksToString(_machine.mir.MAR.Bits);
            this.txtMBR.Text = Machine.Machine.TracksToString(_machine.mir.MBR.Bits);
            this.txtRD.Text = Machine.Machine.TracksToString(_machine.mir.RD.Bits);
            this.txtSH.Text = Machine.Machine.TracksToString(_machine.mir.SH.Bits);
            this.txtWR.Text = Machine.Machine.TracksToString(_machine.mir.WR.Bits);
            base.OnPaint(e);
        }

    }
}
