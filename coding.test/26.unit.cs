namespace coding.test;

public class Class26Test
{
    [Theory]
    [InlineData(new int[] {1, 1, 2}, 2)]
    [InlineData(new int[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4}, 5)]
    public void Test(int[] nums, int expectedResult)
    {
        // Act
        Class26 solution = new Class26();
        int actualResult = solution.RemoveDuplicates(nums);

        Assert.Equal(expectedResult, actualResult);
    }
}