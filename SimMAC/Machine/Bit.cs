public class Bit
{
    private bool _bin;

    public Bit() { }
    public Bit(bool val) { _bin = val; }

    public bool Bin
    {
        get
        {
            return _bin;
        }

        set
        {
            _bin = value;
        }
    }
}

