using Components;

namespace Interface.VisualComponents
{

    public class LM : VisualComponent
    {

        private Components.LM _lm;

        public LM(Component Component) : base(Component)
        {
            _lm = (Components.LM)Component;
            _lm.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
