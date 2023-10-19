using Components;

namespace Interface.VisualComponents
{

    public class ALU : VisualComponent
    {

        private Components.ALU _alu;

        public ALU(Component Component) : base(Component)
        {
            _alu = (Components.ALU)Component;
            _alu.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
