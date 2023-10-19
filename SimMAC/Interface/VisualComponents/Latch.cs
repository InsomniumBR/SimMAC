using Components;

namespace Interface.VisualComponents
{

    public class Latch : VisualComponent
    {

        private Latchs.Latch _latch;

        public Latch(Component Component) : base(Component)
        {
            _latch = (Latchs.Latch)Component;
            _latch.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
