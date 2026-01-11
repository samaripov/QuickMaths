public class CurrentProblem
{
    public string answer { get; set; } = "0";

    public string _topNum { get; set; } = "0";
    public string topNum
    {
        get => _topNum;
        set
        {
            _topNum = value;
            OnCurrentProblemStateChanged();
        }
    }
    public string _bottomNum { get; set; } = "0";
    public string bottomNum
    {
        get => _bottomNum;
        set
        {
            _bottomNum = value;
            OnCurrentProblemStateChanged();
        }
    }
    public string operation = "+";
    public string _numpadInput { get; set; } = "0";
    public string numpadInput
    {
        get => _numpadInput;
        set
        {
            _numpadInput = value;
            OnCurrentProblemStateChanged();
        }
    }

    public event Action CurrentProblemStateChanged;
    protected virtual void OnCurrentProblemStateChanged()
    {
        CurrentProblemStateChanged?.Invoke();
    }

}