using System.Windows.Forms;

namespace MACMount
{
    /// <summary>
    /// Summary description for LinhaPrograma.
    /// </summary>
    public class ProgramLine : System.Windows.Forms.UserControl
    {
        public System.Windows.Forms.ComboBox cmbInstr;
        public System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel _parent;
        private System.Windows.Forms.Label lblLine;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private int _line;

        public int Line
        {
            set
            {
                _line = value;
                lblLine.Text = _line.ToString();
                lblLine.Text = new string('0', 4 - lblLine.Text.Length) + lblLine.Text;
            }
        }

        public ProgramLine(Panel parent)
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            this._parent = parent;
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

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ProgramLine));
            this.cmbInstr = new System.Windows.Forms.ComboBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbInstr
            // 
            this.cmbInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.cmbInstr.Items.AddRange(new object[] {
                                                          "ADDD",
                                                          "ADDL",
                                                          "CALL",
                                                          "DESP",
                                                          "INSP",
                                                          "JNEG",
                                                          "JNZE",
                                                          "JPOS",
                                                          "JUMP",
                                                          "JZER",
                                                          "LOCO",
                                                          "LODD",
                                                          "LODL",
                                                          "POP ",
                                                          "POPI",
                                                          "PSHI",
                                                          "PUSH",
                                                          "RETN",
                                                          "STOD",
                                                          "STOL",
                                                          "STORE",
                                                          "SUBD",
                                                          "SUBL",
                                                          "SWAP"});
            this.cmbInstr.Location = new System.Drawing.Point(48, 0);
            this.cmbInstr.Name = "cmbInstr";
            this.cmbInstr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbInstr.Size = new System.Drawing.Size(88, 21);
            this.cmbInstr.Sorted = true;
            this.cmbInstr.TabIndex = 0;
            this.cmbInstr.Text = "Instruction";
            // 
            // txtAddr
            // 
            this.txtAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtAddr.Location = new System.Drawing.Point(136, 0);
            this.txtAddr.MaxLength = 12;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(104, 21);
            this.txtAddr.TabIndex = 0;
            this.txtAddr.Text = "000000000000";
            this.txtAddr.DoubleClick += new System.EventHandler(this.txtAddr_DoubleClicked);
            // 
            // btnRemover
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemove.Location = new System.Drawing.Point(240, 0);
            this.btnRemove.Name = "btnRemover";
            this.btnRemove.Size = new System.Drawing.Size(32, 24);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblLinha
            // 
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(0, 0);
            this.lblLine.Name = "lblLinha";
            this.lblLine.Size = new System.Drawing.Size(48, 20);
            this.lblLine.TabIndex = 2;
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinhaPrograma
            // 
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.cmbInstr);
            this.Name = "LinhaPrograma";
            this.Size = new System.Drawing.Size(272, 24);
            this.ResumeLayout(false);

        }
        #endregion

        private void btnRemover_Click(object sender, System.EventArgs e)
        {
            _parent.Controls.Remove(this);
        }

        private void txtAddr_DoubleClicked(object sender, System.EventArgs e)
        {
            frmIntbin frm = new frmIntbin(this.txtAddr);
            frm.Show();
        }

    }
}
