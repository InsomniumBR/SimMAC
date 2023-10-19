using Components;

namespace Interface.VisualComponents
{

    public class AMUX : VisualComponent
    {

        private Components.AMUX _amux;

        public AMUX(Component Component) : base(Component)
        {
            _amux = (Components.AMUX)Component;
            _amux.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
