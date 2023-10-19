using Components;

namespace Interface.VisualComponents
{

    public class Mir : VisualComponent
    {

        private Machine.Mir.Mir _Mir;

        public Mir(Component Component) : base(Component)
        {
            _Mir = (Machine.Mir.Mir)Component;
            _Mir.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
