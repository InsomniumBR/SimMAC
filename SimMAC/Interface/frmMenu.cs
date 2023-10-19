using System;
using System.Threading;
using System.Windows.Forms;

namespace Interface
{
    /// <summary>
    /// Summary description for frm_menu.
    /// </summary>
    public class frmMenu : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ListBox Data;
        public System.Windows.Forms.Button Clock;
        private System.Windows.Forms.MainMenu menuBar;
        private System.Windows.Forms.MenuItem menuHelp;
        private System.Windows.Forms.MenuItem menuAbout;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuOpen;
        private System.Windows.Forms.MenuItem menuClose;
        private Machine.Machine _machine;
        private System.Windows.Forms.Label lblStack;
        private System.Windows.Forms.CheckBox chkStack;
        private System.Windows.Forms.Button txtPlay;
        private System.Windows.Forms.Button txtStop;
        private System.Threading.Thread _tRun;
        private Int64 timeToWait = 1000;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnFullClock;
        private System.Windows.Forms.Label lblRDWR;
        private System.Windows.Forms.Label lblInstr;
        private System.Windows.Forms.MenuItem menuItem3;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmMenu(Machine.Machine machine)
        {

            _machine = machine;
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMenu));
            this.Data = new System.Windows.Forms.ListBox();
            this.Clock = new System.Windows.Forms.Button();
            this.lblStack = new System.Windows.Forms.Label();
            this.menuBar = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuOpen = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuClose = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.chkStack = new System.Windows.Forms.CheckBox();
            this.txtPlay = new System.Windows.Forms.Button();
            this.txtStop = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnFullClock = new System.Windows.Forms.Button();
            this.lblRDWR = new System.Windows.Forms.Label();
            this.lblInstr = new System.Windows.Forms.Label();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(8, 24);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(152, 186);
            this.Data.TabIndex = 1;
            // 
            // Clock
            // 
            this.Clock.BackColor = System.Drawing.Color.White;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.Clock.Image = ((System.Drawing.Image)(resources.GetObject("Clock.Image")));
            this.Clock.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Clock.Location = new System.Drawing.Point(8, 232);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(154, 41);
            this.Clock.TabIndex = 3;
            this.Clock.Text = "New Clock";
            this.Clock.Click += new System.EventHandler(this.Clock_Click);
            // 
            // lblStack
            // 
            this.lblStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblStack.Location = new System.Drawing.Point(16, 8);
            this.lblStack.Name = "lblStack";
            this.lblStack.Size = new System.Drawing.Size(40, 16);
            this.lblStack.TabIndex = 5;
            this.lblStack.Text = "Stack";
            // 
            // barraMenu
            // 
            this.menuBar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.menuItem1,
                                                                                      this.menuHelp});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.menuOpen,
                                                                                      this.menuItem3,
                                                                                      this.menuItem2,
                                                                                      this.menuClose});
            this.menuItem1.Text = "File";
            // 
            // menuAbrir
            // 
            this.menuOpen.Index = 0;
            this.menuOpen.Text = "Open Program";
            this.menuOpen.Click += new System.EventHandler(this.menuAbrir_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "-";
            // 
            // menuFechar
            // 
            this.menuClose.Index = 3;
            this.menuClose.Text = "Close";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // menuAjuda
            // 
            this.menuHelp.Index = 1;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.menuAbout});
            this.menuHelp.Text = "Help";
            // 
            // menuSobre
            // 
            this.menuAbout.Index = 0;
            this.menuAbout.Text = "About MAC- 1";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // chkStack
            // 
            this.chkStack.Location = new System.Drawing.Point(64, 8);
            this.chkStack.Name = "chkStack";
            this.chkStack.Size = new System.Drawing.Size(88, 16);
            this.chkStack.TabIndex = 6;
            this.chkStack.Text = "Full Stack?";
            this.chkStack.CheckedChanged += new System.EventHandler(this.chkStack_CheckedChanged);
            // 
            // txtPlay
            // 
            this.txtPlay.Location = new System.Drawing.Point(88, 280);
            this.txtPlay.Name = "txtPlay";
            this.txtPlay.Size = new System.Drawing.Size(32, 24);
            this.txtPlay.TabIndex = 7;
            this.txtPlay.Text = "|>";
            this.txtPlay.Click += new System.EventHandler(this.txtPlay_Click);
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(128, 280);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(32, 24);
            this.txtStop.TabIndex = 8;
            this.txtStop.Text = "| |";
            this.txtStop.Click += new System.EventHandler(this.txtStop_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Location = new System.Drawing.Point(88, 240);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(64, 24);
            this.btnRenew.TabIndex = 9;
            this.btnRenew.Text = "Restart";
            this.btnRenew.Visible = false;
            // 
            // btnFullClock
            // 
            this.btnFullClock.Location = new System.Drawing.Point(16, 280);
            this.btnFullClock.Name = "btnFullClock";
            this.btnFullClock.Size = new System.Drawing.Size(64, 24);
            this.btnFullClock.TabIndex = 10;
            this.btnFullClock.Text = "Full Clock";
            this.btnFullClock.Click += new System.EventHandler(this.btnFullClock_Click);
            // 
            // lblRDWR
            // 
            this.lblRDWR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblRDWR.Location = new System.Drawing.Point(12, 216);
            this.lblRDWR.Name = "lblRDWR";
            this.lblRDWR.Size = new System.Drawing.Size(80, 16);
            this.lblRDWR.TabIndex = 11;
            this.lblRDWR.Text = "RD: 0   WR: 0";
            // 
            // lblInstr
            // 
            this.lblInstr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblInstr.Location = new System.Drawing.Point(104, 214);
            this.lblInstr.Name = "lblInstr";
            this.lblInstr.Size = new System.Drawing.Size(48, 16);
            this.lblInstr.TabIndex = 12;
            this.lblInstr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Open Microprogram";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(170, 310);
            this.Controls.Add(this.lblRDWR);
            this.Controls.Add(this.btnFullClock);
            this.Controls.Add(this.txtStop);
            this.Controls.Add(this.txtPlay);
            this.Controls.Add(this.chkStack);
            this.Controls.Add(this.lblStack);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.lblInstr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(820, 0);
            this.Menu = this.menuBar;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void menuAbout_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(null,
@"Developed by : Wagner Bertolini Junior 
                 Eduardo Zanata Tavares 
Date : 1º Semester / 2004", "About");
        }

        private void Clock_Click(object sender, System.EventArgs e)
        {
            Manager.Clock();
            chkStack_CheckedChanged(sender, e);
        }

        private void ReloadStack()
        {
            ReloadStack(30);
        }

        private void menuClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnFullClock_Click(object sender, System.EventArgs e)
        {
            if (Manager._clockState == Manager.ClockState.Inativa) Clock_Click(null, null);
            while (Manager._clockState != Manager.ClockState.Inativa)
                Clock_Click(null, null);
        }

        private void frmMenu_Load(object sender, System.EventArgs e)
        {
        }

        /*
		private void btnRenew_Click(object sender, System.EventArgs e)
		{
			Manager.Restart();
		}
		*/

        private void txtStop_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (_tRun != null)
                    if (_tRun.ThreadState == ThreadState.Running)
                    {
                        _tRun.Abort();
                        timeToWait = 1000;
                        btnRenew.Enabled = true;
                    }
            }
            catch { }
        }

        private void txtPlay_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (_tRun != null)
                {
                    _tRun.Abort();
                    timeToWait = timeToWait / 2;
                }
                _tRun = new Thread(new ThreadStart(this.SendClock));
                _tRun.Start();
                btnRenew.Enabled = false;
            }
            catch { }
        }

        private void SendClock()
        {
            try
            {
                while (true)
                {
                    DateTime dtAtual = DateTime.Now;
                    DateTime dtFinal = DateTime.Now.AddMilliseconds(timeToWait);

                    while (dtAtual.Ticks < dtFinal.Ticks)
                        dtAtual = DateTime.Now;

                    Clock_Click(null, null);
                }
            }
            catch { }
        }

        private void chkStack_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkStack.Checked) ReloadStack(4096);
            else ReloadStack(30);
        }

        private void ReloadStack(int pos)
        {
            Data.Items.Clear();

            this.Data.SuspendLayout();

            if (pos > Manager.Machine.stack.Size) pos = Manager.Machine.stack.Size;

            string sAddress = string.Empty;
            string sData = string.Empty;

            for (uint i = 0; i < pos; i++)
            {
                sAddress = i.ToString();
                sAddress = new string('0', 4 - sAddress.Length) + sAddress;

                sData = Machine.Machine.TracksToString(Manager.Machine.stack.Get(i).Block);
                Data.Items.Add(sAddress + " | " + sData);
            }

            this.lblRDWR.Text = "RD: " + (Manager.Machine.stack._RD[0].Bit.Bin ? "1" : "0");
            this.lblRDWR.Text += "  WR: " + (Manager.Machine.stack._WR[0].Bit.Bin ? "1" : "0");
            this.lblInstr.Text = GetInstruction(Machine.Machine.TracksToString(Manager.Machine.mbr.ValueStored));

            this.ResumeLayout(true);
        }

        private string GetInstruction(string sTracks)
        {
            string sRet = "";

            if (sTracks.Length == 16)
            {
                string sInstr = sTracks.Substring(0, 4);
                string sSubInstr = sTracks.Substring(4, 3);

                switch (sInstr)
                {
                    case "0000": sRet = "LODD"; break;
                    case "0001": sRet = "STOD"; break;
                    case "0010": sRet = "ADDD"; break;
                    case "0011": sRet = "SUBD"; break;
                    case "0100": sRet = "JPOS"; break;
                    case "0101": sRet = "JZER"; break;
                    case "0110": sRet = "JUMP"; break;
                    case "0111": sRet = "LOCO"; break;
                    case "1000": sRet = "LODL"; break;
                    case "1001": sRet = "STOL"; break;
                    case "1010": sRet = "ADDL"; break;
                    case "1011": sRet = "SUBL"; break;
                    case "1100": sRet = "JNEG"; break;
                    case "1101": sRet = "JNZE"; break;
                    case "1110": sRet = "CALL"; break;
                    case "1111":
                        switch (sSubInstr)
                        {
                            case "000": sRet = "PSHI"; break;
                            case "001": sRet = "POPI"; break;
                            case "010": sRet = "PUSH"; break;
                            case "011": sRet = "POP "; break;
                            case "100": sRet = "RETN"; break;
                            case "101": sRet = "SWAP"; break;
                            case "110": sRet = "INSP"; break;
                            case "111": sRet = "DESP"; break;
                        };
                        break;
                }

                /*
					0000	LODD
					0001	STOD
					0010	ADDD
					0011	SUBD
					0100	JPOS
					0101	JZER
					0110	JUMP
					0111	LOCO
					1000	LODL
					1001	STOL
					1010	ADDL
					1011	SUBL
					1100	JNEG
					1101	JNZE
					1110	CALL

					1111	000	PSHI
					1111	001	POPI
					1111	010	PUSH
					1111	011	POP
					1111	100	RETN
					1111	101	SWAP
					1111	110	INSP
					1111	111	DESP
				 */
            }

            return sRet;
        }

        private void menuAbrir_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Program";
            ofd.Title = "Select the program to open...";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
                Manager.LoadProgram(ofd.FileName);

            chkStack_CheckedChanged(sender, e);
        }

        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "MemCtrl";
            ofd.Title = "Select the microprogram to open...";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
                Manager.LoadMemCtrl(ofd.FileName);

            chkStack_CheckedChanged(sender, e);
        }
    }
}
