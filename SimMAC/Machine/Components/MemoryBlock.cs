namespace Components
{
    /// <summary>
    /// Summary description for MemoryBlock.
    /// </summary>
    public class MemoryBlock
    {
        public MemoryBlock(int BlockSize)
        {
            Block = Track.GetArray(BlockSize);
        }

        public Track[] Block { get; set; }
    }
}
