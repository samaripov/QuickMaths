public class CurrentProblem
{
    public string answer { get; set; } = "";
    public int _timerTime { get; set; } = 300;
    public int timerTime
    {
        get => _timerTime;
        set
        {
            _timerTime = value;
            OnCurrentProblemStateChanged();
        }
    }
    public int _correctCount { get; set; } = 0;
    public int correctCount
    {
        get => _correctCount;
        set
        {
            _correctCount = value;
            OnCurrentProblemStateChanged();
        }
    }
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
    public string _operation = "+";
    public string operation
    {
        get => _operation;
        set
        {
            _operation = value;
            OnCurrentProblemStateChanged();
        }
    }
    public bool _timerRunning { get; set; } = false;
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