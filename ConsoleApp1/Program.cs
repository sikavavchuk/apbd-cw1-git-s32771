void ShowError(string message)
{
    Console.WriteLine($"[ERROR]: {message}");
}

Console.WriteLine("Enter numbers (e.g. 1 2 3):");
string[] input = Console.ReadLine().Split(' ');
int[] numbers = Array.ConvertAll(input, int.Parse);

Console.WriteLine($"Loaded {numbers.Length} numbers.");

public static class StatisticsHelper {
    public const string AppVersion = "1.0.1";

    public static int CalculateMax(int[] values) 
    {
    int max = values[0];
    foreach (var v in values) if (v > max) max = v;
    return max;
    }

    public double CalculateAverage(int[] values) 
    {
    if (values.Length == 0) return 0;
    double sum = 0;
    foreach (var v in values) sum += v;
    return sum / values.Length;
    }

    public static int CalculateMin(int[] values) { return 0; }
}
