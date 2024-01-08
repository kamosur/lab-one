using ClassLibrary2;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void TestSort()
    {
        var array = new[] { 2, 3.01, 1, 2.05 };
        var arrayChecking = new[] { 3.01, 2.05, 2, 1 };
        Assert.Equal(arrayChecking, Class1.Sorting(array));
    }
    
    [Fact]
    public void TestCountBetween()
    {
        var array = new[] { 2, 3.01, 1, 2.05 };
        var countBetween2and3 = 2;
        Assert.Equal(countBetween2and3, Class1.CountBeetween(array, array.Length, 2, 3));
    }
    
    [Fact]
    public void TestMaxElement()
    {
        var array = new[] { 2, 3.01, 1, 2.05 };
        var indexMaxElement = 1; // 3.01
        Assert.Equal(indexMaxElement, Class1.IndexOfMax(array, array.Length));
    }
    
}