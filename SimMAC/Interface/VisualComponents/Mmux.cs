using Components;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.VisualComponents
{

    public class Mmux : VisualComponent
    {

        private Components.Mmux _mmux;

        public Mmux(Component Component) : base(Component)
        {
            _mmux = (Components.Mmux)Component;
            _mmux.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            string sData = Machine.Machine.TracksToString(_mmux.BusMPC.Tracks);
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
