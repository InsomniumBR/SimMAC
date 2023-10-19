using Components;

namespace Interface.VisualComponents
{

    public class Decoder : VisualComponent
    {

        private Decoders.Decoder _Decoder;

        public Decoder(Component Component) : base(Component)
        {
            _Decoder = (Decoders.Decoder)Component;
            _Decoder.Changed += new Component.ChangedEventHandler(Component_Changed);
        }

        protected override void Component_Changed()
        {
            // > Fetch object information
            // > Change picture characteristics.
        }
    }
}
