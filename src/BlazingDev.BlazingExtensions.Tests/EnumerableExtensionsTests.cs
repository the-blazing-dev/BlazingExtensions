namespace BlazingDev.BlazingExtensions.Tests;

public class EnumerableExtensionsTests
{
    [Fact]
    public void SafeAny()
    {
        Test(false, null);
        Test(false, []);
        Test(true, [1]);

        void Test(bool expected, int[]? values)
        {
            Assert.Equal(expected, values.SafeAny());
        }
    }
    
    [Fact]
    public void IsEmpty()
    {
        Test(true, null);
        Test(true, []);
        Test(false, [1]);

        void Test(bool expected, int[]? values)
        {
            Assert.Equal(expected, values.IsEmpty());
        }
    }
}