using DataApp;

public class Program
{
    public static void Main(string[] args)
    {
        var manager = new DataManager();
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(manager.FetchAndStoreData(i));
        }
        
        Console.WriteLine(manager.FetchAndStoreData(27));
        
        Console.WriteLine("Completed");
    }
}