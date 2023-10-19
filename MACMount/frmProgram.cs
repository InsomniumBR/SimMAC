using System.Collections;
using System.Windows.Forms;

namespace MACMount
{
    /// <summary>
    /// Summary description for frmPrograma.
    /// </summary>
    public class frmProgram : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel pnlProgram;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Button btnRemoveLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmProgram(Form f)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            this.MdiParent = f;
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
            this.pnlProgram = new System.Windows.Forms.Panel();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnRemoveLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlProgram
            // 
            this.pnlProgram.AutoScroll = true;
            this.pnlProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProgram.Location = new System.Drawing.Point(144, 44);
            this.pnlProgram.Name = "pnlProgram";
            this.pnlProgram.Size = new System.Drawing.Size(608, 709);
            this.pnlProgram.TabIndex = 0;
            this.pnlProgram.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ReCount);
            this.pnlProgram.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.ReCount);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(16, 44);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(116, 74);
            this.btnAddLine.TabIndex = 1;
            this.btnAddLine.Text = "New Line";
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // btnRemoveLine
            // 
            this.btnRemoveLine.Location = new System.Drawing.Point(16, 133);
            this.btnRemoveLine.Name = "btnRemoveLine";
            this.btnRemoveLine.Size = new System.Drawing.Size(116, 74);
            this.btnRemoveLine.TabIndex = 2;
            this.btnRemoveLine.Text = "Generate Output";
            this.btnRemoveLine.Click += new System.EventHandler(this.btnRemoveLine_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Line";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Instruction";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value";
            // 
            // frmProgram
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(784, 785);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveLine);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.pnlProgram);
            this.Name = "frmProgram";
            this.Text = "Program";
            this.Load += new System.EventHandler(this.frmProgram_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void frmProgram_Load(object sender, System.EventArgs e)
        {

        }

        private void btnAddLine_Click(object sender, System.EventArgs e)
        {
            ProgramLine p = new ProgramLine(pnlProgram);
            p.Top = (pnlProgram.Controls.Count * p.Height) + 5;
            pnlProgram.Controls.Add(p);
        }

        public void ReCount(object sender, ControlEventArgs e)
        {
            int Count = 0;
            foreach (Control c in pnlProgram.Controls)
            {
                ProgramLine p = ((ProgramLine)c);
                p.Line = Count;
                p.Top = (Count * p.Height) + 5;
                Count++;
            }
        }

        private void btnRemoveLine_Click(object sender, System.EventArgs e)
        {
            if (pnlProgram.Controls.Count > 0)
            {
                if (VerifyInstruction())
                {
                    frmOutput frm = new frmOutput(GenerateOutput(pnlProgram.Controls));
                    frm.Show();
                }
            }
            else
                MessageBox.Show(this, "The program must have at least one line of code!", "Alert!");
        }

        private bool VerifyInstruction()
        {
            bool bRet = true;

            foreach (Control c in pnlProgram.Controls)
            {
                ProgramLine p = (ProgramLine)c;

                if (p.cmbInstr.Text.Equals("Instruction"))
                {
                    MessageBox.Show(this, "It is necessary to select instructions on every line of the program!" +
                        "\nIf you want to place only one value in memory, use STORE.", "Alert!");

                    bRet = false;
                    break;
                }
            }

            return bRet;
        }

        private ArrayList GenerateOutput(System.Windows.Forms.Control.ControlCollection controls)
        {

            ArrayList al = new ArrayList();

            foreach (Control c in controls)
            {
                string sLine = "";
                ProgramLine p = (ProgramLine)c;

                // Pega isntrução.
                sLine += GetInstruction(p.cmbInstr.Text);

                // Pega Endereço
                if (sLine.Length > 4)
                    sLine += p.txtAddr.Text.Substring(3);
                else
                    sLine += p.txtAddr.Text;

                al.Add(sLine);
            }

            return al;
        }

        private string GetInstruction(string sMenmonic)
        {
            switch (sMenmonic)
            {
                case "LODD": return "0000";
                case "STOD": return "0001";
                case "ADDD": return "0010";
                case "SUBD": return "0011";
                case "JPOS": return "0100";
                case "JZER": return "0101";
                case "JUMP": return "0110";
                case "LOCO": return "0111";
                case "LODL": return "1000";
                case "STOL": return "1001";
                case "ADDL": return "1010";
                case "SUBL": return "1011";
                case "JNEG": return "1100";
                case "JNZE": return "1101";
                case "CALL": return "1110";
                case "PSHI": return "1111000";
                case "POPI": return "1111001";
                case "PUSH": return "1111010";
                case "POP ": return "1111011";
                case "RETN": return "1111100";
                case "SWAP": return "1111101";
                case "INSP": return "1111110";
                case "DESP": return "1111111";
                case "STORE": return "0000";
                default:
                    MessageBox.Show(this, "Invalid instruction!\nSome lines may not have been generated correctly!", "Error!");
                    return "";
            }
        }
    }
}
