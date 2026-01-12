public class CurrentProblem
{
    public string answer { get; set; } = "";
    private int _timerTime { get; set; } = 300;
    public int timerTime
    {
        get => _timerTime;
        set
        {
            _timerTime = value;
            OnCurrentProblemStateChanged();
        }
    }
    private string _topNum { get; set; } = "0";
    public string topNum
    {
        get => _topNum;
        set
        {
            _topNum = value;
            OnCurrentProblemStateChanged();
        }
    }
    private string _bottomNum { get; set; } = "0";
    public string bottomNum
    {
        get => _bottomNum;
        set
        {
            _bottomNum = value;
            OnCurrentProblemStateChanged();
        }
    }
    private string _operation = "+";
    public string operation
    {
        get => _operation;
        set
        {
            _operation = value;
            OnCurrentProblemStateChanged();
        }
    }
    private bool _timerRunning { get; set; } = false;
    public bool timerRunning
    {
        get => _timerRunning;
        set
        {
            _timerRunning = value;
            OnCurrentProblemStateChanged();
        }
    }
    public System.Timers.Timer? timer { get; set; }
    private string _numpadInput { get; set; } = "0";
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