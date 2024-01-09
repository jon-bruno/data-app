# DataApp 

This is a sample application that needs some work done to it.  Think of these two items as tickets to complete:

1. The function DataApp.DataManager.ConsolidateDataFromSources returns three possible values (0, -1, & -2). The issue is there are no unit tests for this method. The task is to add at least 3 unit tests to the `DataApp.Tests` project to validate the 3 possible code paths.

2. The `DataApp.Program.Main` method is really slow and bound by network I/O. Update the code so all calls to `ConsolidateDataFromSources` (1-10 *and* 27) execute concurrently. In no required order, each call should print their return value to the console. Once complete print `"Completed"`.


# Rules

You can not break any existing functionality.

There are two methods, `DataApp.DataFetcher.FetchData` and `DataApp.DataStorage.StoreData` surrounded by comment lines `// Implementation locked - do not change` and `// End of locked implementation`. You can not make any changes to those sections, but you can make changes to the classes surrounding them. 

`DataApp.DataManager` should still call the methods `FetchData` and `StoreData`.

You may add or modify any other code (including adding/changing class names, variables, libraries, etc).  

Your solution should still compile successfully and pass all unit tests.

Use any and all resources available to you (Google, StackOverflow, previous code you've written, etc).

Bring a copy of your solution with you to the technical interview, we will review it together.  Be prepared to explain any changes made.