using Components;
using Registers;

namespace Latchs
{
    public class Latch : Register
    {
        /*
		private Track[] _Value;

		public Track[] Value
		{
			get
			{
				return _Value;
			}
			set
			{
				_Value = value;
			}
		}
		*/

        public override void Process(Component src, Component[] comp)
        {
            this.Value = (Track[])comp;
        }
    }
}
