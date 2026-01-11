using System.Dynamic;

public class QuickMathsConfig
{
    // Math configs
    public int roundDurationInSeconds { get; set; } = 300;
    public string numbersToFocusOn { get; set; } = "2, 3, 4, 5, 6, 7, 8, 9";
    public string selectedDifficulty { get; set; } = "Normal";
    public List<string> selectedOperations { get; set; } = new List<string>();

    // Options
    public string[] difficultyOptions { get; } = { "Easy", "Normal", "Hard" };
    public List<string> operationsOptions { get; } = new List<string> { "+", "-", "×", "÷" };

    // Singleton methods
    public override string ToString()
    {
        var operations = "";

        foreach (var option in selectedOperations)
        {
            operations += $"{option}, ";
        }

        return $@"
            Time: { roundDurationInSeconds } sec
            Focus: { numbersToFocusOn }
            Difficulty: { selectedDifficulty }
            Operations: { operations }
        ";
    }
}