namespace DataApp;

internal class DataFetcher
{
    // Implementation locked - do not change
    public string FetchData(int dataId)
    {
        return File.ReadAllText($"\\NETDATASOURCES\\{dataId}.dat");
    }
    // End of locked implementation
}