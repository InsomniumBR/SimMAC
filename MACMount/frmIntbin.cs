using System;
using System.Windows.Forms;

namespace MACMount
{
    /// <summary>
    /// Summary description for frmIntbin.
    /// </summary>
    public class frmIntbin : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdInt;
        private System.Windows.Forms.RadioButton rdBin;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtParent;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmIntbin(TextBox t)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            txtParent = t;
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBin = new System.Windows.Forms.RadioButton();
            this.rdInt = new System.Windows.Forms.RadioButton();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBin);
            this.groupBox1.Controls.Add(this.rdInt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rdBin
            // 
            this.rdBin.Checked = true;
            this.rdBin.Location = new System.Drawing.Point(16, 44);
            this.rdBin.Name = "rdBin";
            this.rdBin.Size = new System.Drawing.Size(160, 30);
            this.rdBin.TabIndex = 1;
            this.rdBin.TabStop = true;
            this.rdBin.Text = "Binary";
            this.rdBin.CheckedChanged += new System.EventHandler(this.rdBin_CheckedChanged);
            // 
            // rdInt
            // 
            this.rdInt.Location = new System.Drawing.Point(16, 89);
            this.rdInt.Name = "rdInt";
            this.rdInt.Size = new System.Drawing.Size(160, 29);
            this.rdInt.TabIndex = 0;
            this.rdInt.Text = "Integer";
            this.rdInt.CheckedChanged += new System.EventHandler(this.rdInt_CheckedChanged);
            // 
            // txtVal
            // 
            this.txtVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal.Location = new System.Drawing.Point(320, 22);
            this.txtVal.MaxLength = 12;
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(208, 35);
            this.txtVal.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(416, 103);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 45);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Set";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmIntbin
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(569, 201);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmIntbin";
            this.Text = "Value Adjustment";
            this.Load += new System.EventHandler(this.frmIntbin_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void frmIntbin_Load(object sender, System.EventArgs e)
        {
            txtVal.Text = txtParent.Text;
        }

        private void rdInt_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rdInt.Checked)
                txtVal.Text = (ConvertToInt(txtVal.Text).ToString());
        }

        private int ConvertToInt(string bValor)
        {
            int result = 0;

            for (int i = 11; i > -1; i--)
            {
                if (bValor[i] == '1')
                    result += (int)Math.Pow(2, 11 - i);
            }

            return result;
        }

        private string ConvertToBin(string iValor)
        {
            char[] cRet = new string('0', 12).ToCharArray();

            try
            {
                Int64 valor = Convert.ToInt64(iValor);

                for (int i = 0; i < 12; i++)
                {
                    Int64 x = (Int64)Math.Pow(2, 11 - i);
                    object o = (x & valor);
                    cRet[i] = o.ToString()[0] == '0' ? '0' : '1';
                }
            }
            catch
            { }

            return new string(cRet);
        }

        private void rdBin_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rdBin.Checked)
                txtVal.Text = (ConvertToBin(txtVal.Text));
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            if (rdInt.Checked)
                txtParent.Text = ConvertToBin(txtVal.Text);
            else
                txtParent.Text = txtVal.Text;

            this.Hide();
        }
    }
}
