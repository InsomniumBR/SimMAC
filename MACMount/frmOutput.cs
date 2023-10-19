using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace MACMount
{
    /// <summary>
    /// Summary description for frmSaida.
    /// </summary>
    public class frmOutput : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnSave;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmOutput(ArrayList al)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            string[] sLines = new string[al.Count];

            for (int i = 0; i < al.Count; i++)
                sLines[i] = (string)al[i];

            txtOutput.Lines = sLines;

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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(8, 8);
            this.txtOutput.MaxLength = 16;
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(136, 248);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 48);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save to file";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSaida
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(216, 270);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOutput);
            this.Name = "frmOutput";
            this.Text = "Main Memory";
            this.Load += new System.EventHandler(this.frmOutput_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void frmOutput_Load(object sender, System.EventArgs e)
        {

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            // Mostra Dialogo de Save.
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Program";
            sfd.Title = "Select the file to save...";
            sfd.OverwritePrompt = true;
            DialogResult dr = sfd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                StreamWriter sw = File.CreateText(sfd.FileName);
                foreach (string s in txtOutput.Lines)
                    sw.WriteLine(s);
                sw.Close();

                MessageBox.Show(this, "File saved successfully!", "Alert!");
            }
        }
    }
}
