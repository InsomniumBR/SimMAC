using Components;

namespace Interface.VisualComponents
{

    public class SimStack : VisualComponent
    {

        private Components.SimStack _stack;

        public SimStack(Component Component) : base(Component)
        {
            _stack = (Components.SimStack)Component;
            _stack.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
