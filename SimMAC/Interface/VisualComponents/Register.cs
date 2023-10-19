using Components;

namespace Interface.VisualComponents
{

    public class Register : VisualComponent
    {

        private Registers.Register _reg;

        public Register(Component Component) : base(Component)
        {
            _reg = (Registers.Register)Component;
            _reg.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
