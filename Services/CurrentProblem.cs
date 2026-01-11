public class CurrentProblem
{
    public string topNum { get; set; } = "0";
    public string bottomNum { get; set; } = "0";
    public string operation = "+";
    public string answer { get; set; } = "0";


    public string _numpadInput { get; set; } = "0";
    public string numpadInput
    {
        get => _numpadInput;
        set
        {
            Console.WriteLine(value);
            _numpadInput = value;
            OnNumpadInputChanged();
        }
    }

    public event Action numpadInputChanged;
    protected virtual void OnNumpadInputChanged()
    {
        numpadInputChanged?.Invoke();
    }

}