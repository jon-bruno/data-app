namespace DataApp.Tests;

public class UnitTest1
{
    public DataManager testManager = new DataManager();

    [Fact]
    public void TestForZeroReturn()
    {
        Assert.Equal(0, testManager.ConsolidateDataFromSources(29));
    }

    [Fact]
    public void TestForNegOneReturn()
    {
        Assert.Equal(-1, testManager.ConsolidateDataFromSources(-10));
    }

    [Fact]
    public void TestForNegTwoReturn()
    {
        Assert.Equal(-2, testManager.ConsolidateDataFromSources(5));
    }
}
