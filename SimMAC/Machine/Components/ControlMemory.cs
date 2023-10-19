using Buss;

namespace Components
{
    /// <summary>
    /// Summary description for MemControle.
    /// </summary>
    public class ControlMemory : Component
    {
        #region Attributes
        #endregion

        #region Properties
        public Bus32 BusMir { get; set; }
        #endregion

        MemoryBlock[] _memory;

        public ControlMemory()
        {
            _memory = new MemoryBlock[256];
        }

        public void AddAt(MemoryBlock block, int index)
        {
            _memory[index] = block;
        }

        public MemoryBlock Get(int index)
        {
            return _memory[index];
        }

        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            BusMir.Tracks = Get((int)Machine.Machine.BinaryToInt((Track[])comp)).Block;
        }

        public void ReNew()
        {
            _memory = new MemoryBlock[256];
        }
    }

}
