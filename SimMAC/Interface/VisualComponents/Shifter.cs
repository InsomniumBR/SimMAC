using Components;

namespace Interface.VisualComponents
{

    public class Shifter : VisualComponent
    {

        private Components.Shifter _Shifter;

        public Shifter(Component Component) : base(Component)
        {
            _Shifter = (Components.Shifter)Component;
            _Shifter.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
