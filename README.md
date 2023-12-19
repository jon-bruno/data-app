# DataApp 

This is a sample application that needs some work done to it.  Think of these as your tickets:

1. Write unit tests to validate the three possible outcomes of DataApp.DataManager.FetchAndStoreData
2. Change DataApp.Program.Main to execute the 11 statements(FetchAndStoreData for 1-10 and 27) in parallel and wait for them all to complete before printing "Complete".


# Rules

You can not break any functionality

There are two places, in DataApp.DataFetcher and DataApp.DataStorage, that have ranges where you must not change the implementation. Between the comments `// Implementation locked - do not change` and `// End of locked implementation`, you may not change any code.