namespace TwistedFizzBuzzTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int [] testRange = new int[5]  { 99,  98, 92, 97, 95};
        TwistedFizzBuzz testObj = new TwistedFizzBuzz(testRange);

        !AssemblyLoadEventArgs.Empty(testObj.getRange());
    }
}