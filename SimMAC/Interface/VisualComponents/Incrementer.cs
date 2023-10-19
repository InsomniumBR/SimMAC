using Components;
using System.Drawing;
using System.Windows.Forms;

namespace Interface.VisualComponents
{

    public class Incrementer : VisualComponent
    {

        private Components.Incrementer _incrementador;

        public Incrementer(Component Component) : base(Component)
        {
            _incrementador = (Components.Incrementer)Component;
            _incrementador.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            string sData = Machine.Machine.TracksToString(_incrementador.BusMmux.Tracks);
            Font font = new Font("Verdana", 8, FontStyle.Bold);
            Pen pen = new Pen(Brushes.Black, 5);
            Rectangle r = new Rectangle(Location.X - 73, Location.Y + 6, 68, 14);

            Graphics g = this.Parent.CreateGraphics();
            g.DrawRectangle(pen, r);
            g.FillRectangle(Brushes.White, r);
            g.DrawString(sData, font, Brushes.Black, r);
        }
    }
}
