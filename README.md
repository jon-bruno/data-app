# DataApp 

This is a sample application that needs some work done to it.  Think of these two items as your tickets to complete:

1. The function DataApp.DataManager.ConsolidateDataFromSources returns three possible values (0, -1, & -2), but we have no unit tests for it.  Add at least 3 unit tests to the DataApp.Tests project validating the possible code paths.  These tests should pass, and not change the data.

2. The DataApp.Program.Main method is really slow and bound by network I/O.  Add parallelism to allow all 11 calls to `ConsolidateDataFromSources` (1-10 *and* 27) to execute concurrently.  In no required order, the results of each call should all complete and print their outcome to the console before printing the line `"Completed"`.


# Rules

You can not break any functionality.

There are two places, in DataApp.DataFetcher and DataApp.DataStorage, that have ranges where you must not change the implementation. Between the comments `// Implementation locked - do not change` and `// End of locked implementation`, you may not change any code.  You cannot change the method definitions themselves, but you may make changes to the classes surrounding them.  However, the DataManager should still call the methods `FetchData` and `StoreData`.

All other code is fair game for changes, you may add or modify any code you need (including adding/changing class names, variables, etc).  Your solution should still compile successfully.

Use any and all resources you have available to you (Google, StackOverflow, previous code you've written, etc).

Bring your solution with you to the technical interview, we will review it together.  Be prepared to explain any changes you made.