using Buss;

namespace Components
{
    /// <summary>
    /// Summary description for Stack.
    /// </summary>
    public class SimStack : Component
    {
        int index = 4095;
        MemoryBlock[] _memory;

        public Bus16 _busAddress;
        public BusBID _busData;
        public Track[] _RD;
        public Track[] _WR;

        public SimStack()
        {
            _memory = new MemoryBlock[4096];

            for (int i = 0; i < _memory.Length; i++)
                _memory[i] = new MemoryBlock(16);

            index = 4020;

            _RD = Track.GetArray(1);
            _WR = Track.GetArray(1);
        }

        public void Push(MemoryBlock block)
        {
            _memory[index] = block;
            index--;
        }

        public void Set(MemoryBlock block, uint index)
        {
            _memory[index] = block;
        }

        public MemoryBlock Get(uint index)
        {
            return _memory[index];
        }

        public MemoryBlock Pop()
        {
            MemoryBlock mb = _memory[index];
            _memory[index] = null;
            index++;
            return mb;
        }

        public MemoryBlock Top()
        {
            return _memory[index];
        }

        public bool IsEmpty()
        {
            return (index == 4020);
        }

        public int Size
        {
            get
            {
                return (4020 - index);
            }
        }

        public void RecalcSize()
        {
            this.index = 4020;
            for (int i = 0; i < this._memory.Length; i++)
                if (this._memory[i] != null) this.index--;
        }
        public override void Process(Component src, Component comp) { }
        public override void Process(Component src, Component[] comp)
        {
            if (((Bus)src).Name.Equals("MirRD2Stack"))
                this._RD = (Track[])comp;
            else if (((Bus)src).Name.Equals("MirWR2Stack"))
                this._WR = (Track[])comp;
            else  //if (((Bus)src).Name.Equals("BusBID"))
            {
                //				if (this.RD[0].Bit.Bin)
                _busData.Tracks =
                    this.Get(Machine.Machine.BinaryToInt((Track[])comp)).Block;
                if (this._WR[0].Bit.Bin)
                {
                    MemoryBlock mb = new MemoryBlock(16);
                    mb.Block = (Track[])comp;
                    this.Set(mb, Machine.Machine.BinaryToInt(_busAddress.Tracks));
                }
            }
        }

        public void ReNew()
        {
            _memory = new MemoryBlock[4096];

            for (int i = 0; i < _memory.Length; i++)
                _memory[i] = new MemoryBlock(16);

            index = 4020;
        }
    }

}
