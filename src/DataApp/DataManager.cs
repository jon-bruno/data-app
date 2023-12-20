namespace DataApp;

public class DataManager
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
    /// </summary>
    /// <returns>-1 if an invalid dataId (less than 0) is provided, -2 if the data fetched from the supplied ID was null or whitespace,
    /// or 0 if we successfully consolidated.
    /// </returns>
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