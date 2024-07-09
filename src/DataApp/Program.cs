namespace DataApp;

public class Program
{
    //Change to task for concurrency
    public static async Task Main(string[] args)
    {
        var manager = new DataManager();
        //Create a list for the data Id's to allow dynamic changes
        List<int> dataIds = new List<int>()
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 27
        };
        //Number of concurrent tasks we want
        var tasks = new Task[dataIds.Count];

        //Run the tasks
        for (int i = 0; i < dataIds.Count; i++)
        {
            int dataId = dataIds[i];
            tasks[i] = Task.Run(() => Console.WriteLine($"Consolidated dataId {dataId}. Result=" + manager.ConsolidateDataFromSources(dataId)));
        }

        //Wait for all tasks to complete before writing completed
        await Task.WhenAll(tasks);
        Console.WriteLine("Completed");
    }
}