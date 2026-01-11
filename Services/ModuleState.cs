public class ModuleState
{
    public bool _Visible { get; set; }
    public bool Visible
    {
        get => _Visible;
        set
        {
            _Visible = value;
            OnModuleStateChanged();
        }
    }

    public event Action ModuleStateChanged;
    protected virtual void OnModuleStateChanged()
    {
        ModuleStateChanged?.Invoke();
    }
}