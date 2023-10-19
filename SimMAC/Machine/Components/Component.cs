namespace Components
{
    public abstract class Component
    {
        public delegate void ChangedEventHandler();
        public event ChangedEventHandler Changed;

        public virtual void OnChanged()
        {
            if (Changed != null) Changed();
        }
        public abstract void Process(Component src, Component comp);
        public abstract void Process(Component src, Component[] comp);
    }
}