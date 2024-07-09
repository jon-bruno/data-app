namespace DataApp;

public class DataManager
{
    private DataFetcher _dataFetcher;
    private DataStorage _dataStorage;
    private const string LOCALPATH = "C:/Users/Sean/Source/Repos/data-app/src/DataApp/Data/";
    public DataManager()
    {
        _dataFetcher = new DataFetcher();
        _dataStorage = new DataStorage();
    }


    public int ConsolidateDataFromSources(int dataId)
    {
        if (dataId < 0) 
        {
            return -1;
        }

        var data = ""; 

        //Check to see if data is already stored
        try
        {
            data = _dataFetcher.FetchData(dataId);
        }
        catch (Exception ex) 
        {
            data = FetchGeneratedData(dataId);
        }

        //When the data does not exist
        if (string.IsNullOrWhiteSpace(data))
        {
            return -2;
        }

        // Store data that exists and is not already stored
        try
        {
            _dataStorage.StoreData(dataId, data);
        }
        catch (Exception ex) 
        {
            StoreFetchedData(dataId, data);
        }

        return 0;
    }

    //Catch Local Generated Data
    public string FetchGeneratedData(int dataId)
    {
        //try to get the file
        try
        {
            return File.ReadAllText($"{LOCALPATH}{dataId}.dat");
        }
        catch (Exception ex) 
        {
            //If no data exists, return empty string
            return "";
        }
    }

    //Store data locally if needed
    public void StoreFetchedData(int dataId, string data)
    {
        File.AppendAllText($"{LOCALPATH}{dataId}.dat", data);
    }

    /*
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
    */
}