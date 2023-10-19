using Components;

namespace Interface.VisualComponents
{

    public class Bus : VisualComponent
    {

        private Buss.Bus _Bus;

        public Bus(Component Component) : base(Component)
        {
            _Bus = (Buss.Bus)Component;
            _Bus.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
