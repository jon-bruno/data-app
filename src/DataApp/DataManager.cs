namespace DataApp;

internal class DataManager
{
    private DataFetcher _dataFetcher;
    private DataStorage _dataStorage;

    public DataManager()
    {
        _dataFetcher = new DataFetcher();
        _dataStorage = new DataStorage();
    }

    public int FetchAndStoreData(int dataId)
    {
        if (dataId < 0)
        {
            return -1;
        }

        var data = _dataFetcher.FetchData(dataId);
        if (string.IsNullOrWhiteSpace(data))
        {
            return -2;
        }
        _dataStorage.StoreData(dataId, data);
        return 0;
    }
}