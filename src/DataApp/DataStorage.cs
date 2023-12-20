namespace DataApp;

internal class DataStorage
{
    // Implementation locked - do not change
    public void StoreData(int dataId, string data)
    {
        File.AppendAllText($"\\\\NETDATASTORAGE\\{dataId}.dat", data);
    }
    // End of locked implementation
}