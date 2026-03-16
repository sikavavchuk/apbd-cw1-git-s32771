void ShowError(string message)
{
    Console.WriteLine($"[ERROR]: {message}");
}

double CalculateAverage(int[] values) {
    
}

Console.WriteLine("Enter numbers (e.g. 1 2 3):");
string[] input = Console.ReadLine().Split(' ');
int[] numbers = Array.ConvertAll(input, int.Parse);

Console.WriteLine($"Loaded {numbers.Length} numbers.");

public static class StatisticsHelper {
    public const string AppVersion = "1.0.1";
}
