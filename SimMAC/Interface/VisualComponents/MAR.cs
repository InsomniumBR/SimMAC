using Components;

namespace Interface.VisualComponents
{

    public class MAR : VisualComponent
    {

        private Components.MAR _mar;

        public MAR(Component Component) : base(Component)
        {
            _mar = (Components.MAR)Component;
            _mar.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
