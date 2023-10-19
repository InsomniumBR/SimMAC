using Components;
using System.Windows.Forms;

namespace Interface.VisualComponents
{
    public abstract class VisualComponent : PictureBox
    {
        #region Attributes
        #endregion

        #region Properties
        public Component Component { get; set; }

        #endregion

        public VisualComponent(Component Component)
        {
            this.Component = Component;
            this.Component.Changed += new Components.Component.ChangedEventHandler(Component_Changed);
        }

        protected abstract void Component_Changed();

    }
}
