using Components;

namespace Interface.VisualComponents
{

    public class MBR : VisualComponent
    {

        private Components.MBR _mbr;

        public MBR(Component Component) : base(Component)
        {
            _mbr = (Components.MBR)Component;
            _mbr.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
