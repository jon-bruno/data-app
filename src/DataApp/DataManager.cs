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

    /// <summary>
    /// Consolidate the data from the DataFetcher sources into a centralized data store.
    /// Returns -1 if an invalid dataId (less than 0) is provided, -2 if the data was null or whitespace,
    /// or 0 if we successfully consolidated
    /// </summary>
    public int ConsolidateDataFromSources(int dataId)
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