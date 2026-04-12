namespace coding.test;

public class Class27Test
{
    [Theory]
    [InlineData(new int[] {3, 2, 2, 3}, 3, 2)]
    [InlineData(new int[] {0, 1, 2, 2, 3, 0, 4, 2}, 2, 5)]
    public void Test(int[] nums, int val, int expectedResult)
    {
        // Act
        Class27 solution = new Class27();
        int actualResult = solution.RemoveElement(nums, val);

        Assert.Equal(expectedResult, actualResult);
    }
}