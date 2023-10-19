using System.Windows.Forms;

namespace Interface
{
    /// <summary>
    /// Summary description for frmComponenetes.
    /// </summary>
    public class frmComponents : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox txtMAR;
        private System.Windows.Forms.Label lblMAR;
        private System.Windows.Forms.TextBox txtMBR;
        private System.Windows.Forms.Label lblMBR;
        private System.Windows.Forms.TextBox txtLatchB;
        private System.Windows.Forms.Label lblLatchB;
        private System.Windows.Forms.TextBox txtLatchA;
        private System.Windows.Forms.Label lblLatchA;
        private System.Windows.Forms.TextBox txtALU;
        private System.Windows.Forms.Label lblALU;
        private System.Windows.Forms.TextBox txtAMUX;
        private System.Windows.Forms.Label lblAMUX;
        private System.Windows.Forms.TextBox txtShifter;
        private System.Windows.Forms.Label lblShifter;
        private System.Windows.Forms.TextBox txtNZ;
        private System.Windows.Forms.Label lblNZ;
        private Machine.Machine _machine;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmComponents(Machine.Machine machine)
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

        protected override void OnPaint(PaintEventArgs e)
        {
            this.txtALU.Text = Machine.Machine.TracksToString(_machine.alu.ValueR);
            this.txtAMUX.Text = Machine.Machine.TracksToString(_machine.amux.BusALU.Tracks);
            this.txtShifter.Text = Machine.Machine.TracksToString(_machine.Shifter.BusMBR.Tracks);
            this.txtLatchA.Text = Machine.Machine.TracksToString(_machine.latchA.Value);
            this.txtLatchB.Text = Machine.Machine.TracksToString(_machine.latchB.Value);
            this.txtMAR.Text = Machine.Machine.TracksToString(_machine.mar.Value);
            this.txtMBR.Text = Machine.Machine.TracksToString(_machine.mbr.BusData.Tracks);
            this.txtNZ.Text = Machine.Machine.TracksToString(_machine.alu.BusLM.Tracks);
            base.OnPaint(e);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMAR = new System.Windows.Forms.TextBox();
            this.lblMAR = new System.Windows.Forms.Label();
            this.txtMBR = new System.Windows.Forms.TextBox();
            this.lblMBR = new System.Windows.Forms.Label();
            this.txtLatchB = new System.Windows.Forms.TextBox();
            this.lblLatchB = new System.Windows.Forms.Label();
            this.txtLatchA = new System.Windows.Forms.TextBox();
            this.lblLatchA = new System.Windows.Forms.Label();
            this.txtALU = new System.Windows.Forms.TextBox();
            this.lblALU = new System.Windows.Forms.Label();
            this.txtAMUX = new System.Windows.Forms.TextBox();
            this.lblAMUX = new System.Windows.Forms.Label();
            this.txtShifter = new System.Windows.Forms.TextBox();
            this.lblShifter = new System.Windows.Forms.Label();
            this.txtNZ = new System.Windows.Forms.TextBox();
            this.lblNZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMAR
            // 
            this.txtMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtMAR.Location = new System.Drawing.Point(48, 0);
            this.txtMAR.Name = "txtMAR";
            this.txtMAR.ReadOnly = true;
            this.txtMAR.Size = new System.Drawing.Size(122, 20);
            this.txtMAR.TabIndex = 30;
            this.txtMAR.Text = "";
            this.txtMAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMAR
            // 
            this.lblMAR.BackColor = System.Drawing.Color.Lavender;
            this.lblMAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblMAR.ForeColor = System.Drawing.Color.Black;
            this.lblMAR.Location = new System.Drawing.Point(0, 0);
            this.lblMAR.Name = "lblMAR";
            this.lblMAR.Size = new System.Drawing.Size(48, 20);
            this.lblMAR.TabIndex = 29;
            this.lblMAR.Text = "MAR";
            this.lblMAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMBR
            // 
            this.txtMBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtMBR.Location = new System.Drawing.Point(48, 20);
            this.txtMBR.Name = "txtMBR";
            this.txtMBR.ReadOnly = true;
            this.txtMBR.Size = new System.Drawing.Size(122, 20);
            this.txtMBR.TabIndex = 32;
            this.txtMBR.Text = "";
            this.txtMBR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMBR
            // 
            this.lblMBR.BackColor = System.Drawing.Color.Lavender;
            this.lblMBR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblMBR.ForeColor = System.Drawing.Color.Black;
            this.lblMBR.Location = new System.Drawing.Point(0, 20);
            this.lblMBR.Name = "lblMBR";
            this.lblMBR.Size = new System.Drawing.Size(48, 20);
            this.lblMBR.TabIndex = 31;
            this.lblMBR.Text = "MBR";
            this.lblMBR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLatchB
            // 
            this.txtLatchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtLatchB.Location = new System.Drawing.Point(48, 60);
            this.txtLatchB.Name = "txtLatchB";
            this.txtLatchB.ReadOnly = true;
            this.txtLatchB.Size = new System.Drawing.Size(122, 20);
            this.txtLatchB.TabIndex = 36;
            this.txtLatchB.Text = "";
            this.txtLatchB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLatchB
            // 
            this.lblLatchB.BackColor = System.Drawing.Color.Lavender;
            this.lblLatchB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLatchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblLatchB.ForeColor = System.Drawing.Color.Black;
            this.lblLatchB.Location = new System.Drawing.Point(0, 60);
            this.lblLatchB.Name = "lblLatchB";
            this.lblLatchB.Size = new System.Drawing.Size(48, 20);
            this.lblLatchB.TabIndex = 35;
            this.lblLatchB.Text = "Latch B";
            this.lblLatchB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLatchA
            // 
            this.txtLatchA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtLatchA.Location = new System.Drawing.Point(48, 40);
            this.txtLatchA.Name = "txtLatchA";
            this.txtLatchA.ReadOnly = true;
            this.txtLatchA.Size = new System.Drawing.Size(122, 20);
            this.txtLatchA.TabIndex = 34;
            this.txtLatchA.Text = "";
            this.txtLatchA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLatchA
            // 
            this.lblLatchA.BackColor = System.Drawing.Color.Lavender;
            this.lblLatchA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLatchA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblLatchA.ForeColor = System.Drawing.Color.Black;
            this.lblLatchA.Location = new System.Drawing.Point(0, 40);
            this.lblLatchA.Name = "lblLatchA";
            this.lblLatchA.Size = new System.Drawing.Size(48, 20);
            this.lblLatchA.TabIndex = 33;
            this.lblLatchA.Text = "Latch A";
            this.lblLatchA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtALU
            // 
            this.txtALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtALU.Location = new System.Drawing.Point(220, 20);
            this.txtALU.Name = "txtALU";
            this.txtALU.ReadOnly = true;
            this.txtALU.Size = new System.Drawing.Size(122, 20);
            this.txtALU.TabIndex = 40;
            this.txtALU.Text = "";
            this.txtALU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblALU
            // 
            this.lblALU.BackColor = System.Drawing.Color.Lavender;
            this.lblALU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblALU.ForeColor = System.Drawing.Color.Black;
            this.lblALU.Location = new System.Drawing.Point(172, 20);
            this.lblALU.Name = "lblALU";
            this.lblALU.Size = new System.Drawing.Size(48, 20);
            this.lblALU.TabIndex = 39;
            this.lblALU.Text = "ALU";
            this.lblALU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAMUX
            // 
            this.txtAMUX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtAMUX.Location = new System.Drawing.Point(220, 0);
            this.txtAMUX.Name = "txtAMUX";
            this.txtAMUX.ReadOnly = true;
            this.txtAMUX.Size = new System.Drawing.Size(122, 20);
            this.txtAMUX.TabIndex = 38;
            this.txtAMUX.Text = "";
            this.txtAMUX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAMUX
            // 
            this.lblAMUX.BackColor = System.Drawing.Color.Lavender;
            this.lblAMUX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAMUX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblAMUX.ForeColor = System.Drawing.Color.Black;
            this.lblAMUX.Location = new System.Drawing.Point(172, 0);
            this.lblAMUX.Name = "lblAMUX";
            this.lblAMUX.Size = new System.Drawing.Size(48, 20);
            this.lblAMUX.TabIndex = 37;
            this.lblAMUX.Text = "AMUX";
            this.lblAMUX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtShifter
            // 
            this.txtShifter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtShifter.Location = new System.Drawing.Point(220, 60);
            this.txtShifter.Name = "txtShifter";
            this.txtShifter.ReadOnly = true;
            this.txtShifter.Size = new System.Drawing.Size(122, 20);
            this.txtShifter.TabIndex = 44;
            this.txtShifter.Text = "";
            this.txtShifter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblShifter
            // 
            this.lblShifter.BackColor = System.Drawing.Color.Lavender;
            this.lblShifter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShifter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblShifter.ForeColor = System.Drawing.Color.Black;
            this.lblShifter.Location = new System.Drawing.Point(172, 60);
            this.lblShifter.Name = "lblShifter";
            this.lblShifter.Size = new System.Drawing.Size(48, 20);
            this.lblShifter.TabIndex = 43;
            this.lblShifter.Text = "Shift";
            this.lblShifter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNZ
            // 
            this.txtNZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtNZ.Location = new System.Drawing.Point(220, 40);
            this.txtNZ.Name = "txtNZ";
            this.txtNZ.ReadOnly = true;
            this.txtNZ.Size = new System.Drawing.Size(122, 20);
            this.txtNZ.TabIndex = 42;
            this.txtNZ.Text = "";
            this.txtNZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNZ
            // 
            this.lblNZ.BackColor = System.Drawing.Color.Lavender;
            this.lblNZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblNZ.ForeColor = System.Drawing.Color.Black;
            this.lblNZ.Location = new System.Drawing.Point(172, 40);
            this.lblNZ.Name = "lblNZ";
            this.lblNZ.Size = new System.Drawing.Size(48, 20);
            this.lblNZ.TabIndex = 41;
            this.lblNZ.Text = "NZ";
            this.lblNZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmComponents
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(342, 78);
            this.Controls.Add(this.txtShifter);
            this.Controls.Add(this.txtNZ);
            this.Controls.Add(this.txtALU);
            this.Controls.Add(this.txtAMUX);
            this.Controls.Add(this.txtLatchB);
            this.Controls.Add(this.txtLatchA);
            this.Controls.Add(this.txtMBR);
            this.Controls.Add(this.txtMAR);
            this.Controls.Add(this.lblShifter);
            this.Controls.Add(this.lblNZ);
            this.Controls.Add(this.lblALU);
            this.Controls.Add(this.lblAMUX);
            this.Controls.Add(this.lblLatchB);
            this.Controls.Add(this.lblLatchA);
            this.Controls.Add(this.lblMBR);
            this.Controls.Add(this.lblMAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(10, 610);
            this.Name = "frmComponents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main Components";
            this.ResumeLayout(false);

        }
        #endregion
    }
}
