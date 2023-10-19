using Components;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.VisualComponents
{

    public class MPC : VisualComponent
    {

        private Components.MPC _mpc;

        public MPC(Component Component) : base(Component)
        {
            _mpc = (Components.MPC)Component;
            _mpc.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            string sData = Machine.Machine.TracksToString(_mpc.BusControlMemory.Tracks);
            Font font = new Font("Verdana", 8, FontStyle.Bold);
            Pen pen = new Pen(Brushes.Black, 5);
            Rectangle r = new Rectangle(Location.X + this.Width + 2, Location.Y + 3, 68, 14);

            Graphics g = this.Parent.CreateGraphics();
            g.DrawRectangle(pen, r);
            g.FillRectangle(Brushes.White, r);
            g.DrawString(sData, font, Brushes.Black, r);
        }


    }
}
