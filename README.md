# DataApp 

This is a sample application that needs some work done to it.  Think of these two items as your tickets to complete:

1. The function DataApp.DataManager.ConsolidateDataFromSources returns three possible values (0, -1, & -2). The issue is there are no unit tests for this method. Your task is to add at least 3 unit tests to the DataApp.Tests project to validate the 3 possible code paths. These tests should pass, and not manipulate the data returned by DataApp.DataManager.ConsolidateDataFromSources.

2. The DataApp.Program.Main method is really slow and bound by network I/O. Add code so all 11 calls to `ConsolidateDataFromSources` (1-10 *and* 27) execute concurrently. In no required order, each call should run to completion and print their outcome to the console. Once complete print the line `"Completed"`.


# Rules

You can not break any existing functionality.

Do not change any code between the comment lines `// Implementation locked - do not change` and `// End of locked implementation`. 

There are two places, in DataApp.DataFetcher and DataApp.DataStorage, that have code block where you must not change the implementation. Between the comments `// Implementation locked - do not change` and `// End of locked implementation`, you may not make any changes. You cannot change the method definitions of `FetchData` and `StoreData`, but you may make changes to the classes surrounding them. DataManager should still call the methods `FetchData` and `StoreData`. You may add or modify any other code (including adding/changing class names, variables, libraries, etc).  

Your solution should still compile successfully and pass all unit tests.

Use any and all resources available to you (Google, StackOverflow, previous code you've written, etc).

Bring a copy of your solution with you to the technical interview, we will review it together.  Be prepared to explain any changes you made.