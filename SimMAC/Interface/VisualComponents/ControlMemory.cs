using Components;

namespace Interface.VisualComponents
{

    public class ControlMemory : VisualComponent
    {

        private Components.ControlMemory _controlMemory;

        public ControlMemory(Component Component) : base(Component)
        {
            _controlMemory = (Components.ControlMemory)Component;
            _controlMemory.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
