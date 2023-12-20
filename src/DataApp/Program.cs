namespace DataApp;

public class Program
{
    public static void Main(string[] args)
    {
        var manager = new DataManager();
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"Consolidated dataId {i}. Result=" + manager.ConsolidateDataFromSources(i));
        }
        
        Console.WriteLine("Consolidated dataId 27. Result=" + manager.ConsolidateDataFromSources(27));
        
        Console.WriteLine("Completed");
    }
}