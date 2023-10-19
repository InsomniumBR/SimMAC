using Components;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Interface
{
    /// <summary>
    /// Summary description for Manager.
    /// </summary>
    public class Manager
    {
        // Paths dos arquivos
        private static string sPathMemCtrl;
        private static string sPathProgram;

        // Arquivos em memória
        private static string[] sFileMemCtrl;
        private static string[] sFileProgram;

        // A Máquina
        private static Machine.Machine _machine;

        // Forms
        private static frmLoading frmloading = null;
        private static frmMain frmprincipal = null;
        private static frmMir frmmir = null;
        private static frmRegs frmregs = null;
        private static frmMenu frmmenu = null;
        private static frmComponents frmComponents = null;

        // Clock State
        public enum ClockState
        {
            PrimeiroClock,
            SegundoClock,
            TerceiroClock,
            QuartoClock,
            Inativa
        }

        public static ClockState _clockState = ClockState.Inativa;
        public static Machine.Machine Machine { get { return _machine; } set { _machine = value; } }

        [STAThread]
        public static void Main(string[] args)
        {
            sPathMemCtrl = "MemCtrl";
            sPathProgram = "Program";

            // Setndo referências para objetos de interface
            // e criando a máquina.
            _machine = new Machine.Machine(frmprincipal, frmmenu);

            // Passando referência da máquina à interface.
            frmloading = new frmLoading();
            frmprincipal = new frmMain(_machine);
            frmprincipal.GotFocus += new EventHandler(AdjustFocus);
            frmmir = new frmMir(_machine);
            frmregs = new frmRegs(_machine);
            frmmenu = new frmMenu(_machine);
            frmComponents = new frmComponents(_machine);

            LoadMemCtrl();
            LoadProgram();

            frmprincipal.Show();
            frmmenu.Show();
            frmmir.Show();
            frmregs.Show();
            frmComponents.Show();

            _machine.mpc.Process(null, Track.GetArray(8));
            _machine.mpc.Clock();

            frmprincipal.Refresh();
            frmmenu.Refresh();
            frmmir.Refresh();
            frmregs.Refresh();
            frmComponents.Refresh();

            Application.Run(frmprincipal);
        }

        #region Clocks
        #region Clock
        public static void Clock()
        {
            switch (_clockState)
            {
                case ClockState.Inativa:
                    _clockState = ClockState.PrimeiroClock;
                    frmmenu.Clock.Text = "Clock 1";
                    PrimeiroClock();
                    break;

                case ClockState.PrimeiroClock:
                    _clockState = ClockState.SegundoClock;
                    frmmenu.Clock.Text = "Clock 2";
                    SegundoClock();
                    break;

                case ClockState.SegundoClock:
                    _clockState = ClockState.TerceiroClock;
                    frmmenu.Clock.Text = "Clock 3";
                    TerceiroClock();
                    break;

                case ClockState.TerceiroClock:
                    _clockState = ClockState.QuartoClock;
                    frmmenu.Clock.Text = "Clock 4";
                    QuartoClock();
                    break;

                case ClockState.QuartoClock:
                    _clockState = ClockState.Inativa;
                    Reset();
                    frmmenu.Clock.Text = "New Clock";
                    break;
            }

            frmmenu.Refresh();
            frmmenu.Focus();
            frmregs.Refresh();
            frmregs.Focus();
            frmprincipal.Refresh();
            frmprincipal.Focus(); ;
            frmComponents.Refresh();
            frmComponents.Focus();
            frmmir.Refresh();
            frmmir.Focus();
        }
        #endregion
        #region Primeiro Clock
        public static void PrimeiroClock()
        {
            //GAMBI
            for (int i = 0; i < 16; i++)
            {
                _machine.regs.Regs[i].ReadC.Bin = false;
                _machine.regs.Regs[i].WriteA.Bin = false;
                _machine.regs.Regs[i].WriteB.Bin = false;
            }

            _machine.mir.Clock();
        }
        #endregion
        #region Segundo Clock
        public static void SegundoClock()
        {
            _machine.latchA.Clock();
            _machine.latchB.Clock();
        }
        #endregion
        #region Terceiro Clock
        public static void TerceiroClock()
        {
            _machine.mar.Clock();
        }
        #endregion
        #region Quarto Clock
        public static void QuartoClock()
        {
            _machine.mpc.Clock();
            _machine.DecoderC.Clock();
            _machine.regs.Clock();
            _machine.mbr.Clock();
        }
        #endregion
        #endregion

        #region Load Control Memory
        public static void LoadMemCtrl()
        {
            LoadMemCtrl(sPathMemCtrl);
        }
        public static void LoadMemCtrl(string sFileName)
        {
            frmloading = new frmLoading("Loading...", "Loading Control Memory...");
            frmloading.Show();
            frmloading.Refresh();
            Thread.Sleep(1000);

            StreamReader sr = null;
            MemoryBlock m = null;

            try
            {
                sr = File.OpenText(sFileName);
                sFileMemCtrl = new string[256];
                int i = 0;

                while (sr.Peek() != -1)
                    sFileMemCtrl[i++] = sr.ReadLine();

                _machine.memCtrl.ReNew();

                for (int j = 0; j < sFileMemCtrl.Length; j++)
                {
                    m = new MemoryBlock(32);

                    if (sFileMemCtrl[j] == null) break;

                    string sBits = sFileMemCtrl[j].Trim();

                    if (sBits.Length != 32)
                        throw new Exception("Invalid microinstruction size!");

                    for (int k = 0; k < sBits.Length; k++)
                        m.Block[k].Bit = new Bit(sBits[k] == 49);

                    _machine.memCtrl.AddAt(m, j);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sr.Close();
                frmloading.Close();
            }
        }

        #endregion

        #region Load Program
        public static void LoadProgram()
        {
            LoadProgram(sPathProgram);
        }

        public static void LoadProgram(string sFileName)
        {
            frmloading = new frmLoading("Loading...", "Loading Stack...");
            frmloading.Show();
            frmloading.Refresh();
            Thread.Sleep(1000);

            StreamReader sr = null;
            MemoryBlock m = null;

            try
            {
                sr = File.OpenText(sFileName);
                sFileProgram = new string[4020];
                uint i = 0;

                while (sr.Peek() != -1)
                    sFileProgram[i++] = sr.ReadLine();

                _machine.stack.ReNew();

                for (uint j = 0; j < sFileProgram.Length; j++)
                {
                    m = new MemoryBlock(16);

                    if (sFileProgram[j] == null) break;

                    string sBits = sFileProgram[j].Trim();

                    if (sBits.Length != 16)
                        throw new Exception("Invalid microinstruction size!");

                    for (int k = 0; k < sBits.Length; k++)
                        m.Block[k].Bit = new Bit(sBits[k] == 49);

                    _machine.stack.Set(m, j);
                }

                _machine.stack.RecalcSize();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sr.Close();
                frmloading.Close();
            }
        }

        #endregion

        private static void Reset()
        {
            _machine.alu.ValueA = null;
            _machine.alu.ValueB = null;
        }

        private static void AdjustFocus(object sender, EventArgs e)
        {
            frmprincipal.Focus();
            frmmenu.Focus();
            frmregs.Focus();
            frmComponents.Focus();
            frmmir.Focus();
        }

        /*
		public static void Restart()
		{
			frmmenu.Dispose();
			frmmir.Dispose();
			frmregs.Dispose();
			frmComponents.Dispose();

			// Setando referências para objetos de interface
			// e criando a máquina.
			_machine = new Machine.Machine(frmprincipal, frmmenu);

			// Passando referência da máquina à interface.
			frmloading = new frmLoading();
			frmprincipal = new frmPrincipal(_machine);
			frmprincipal.GotFocus +=new EventHandler(AdjustFoco);
			frmmir = new frmMir(_machine);
			frmregs = new frmRegs(_machine);
			frmmenu = new frmMenu(_machine);
			frmComponents = new frmComponents(_machine);

			LoadMemCtrl();
			LoadProgram();

			frmprincipal.Show();
			frmmenu.Show();
			frmmir.Show();
			frmregs.Show();
			frmComponents.Show();

			_machine.mpc.processa(null,Track.GetArray(8));
			_machine.mpc.Clock();

			frmprincipal.Refresh();
			frmmenu.Refresh();
			frmmir.Refresh();
			frmregs.Refresh();
			frmComponents.Refresh();
		}
		*/
    }
}
