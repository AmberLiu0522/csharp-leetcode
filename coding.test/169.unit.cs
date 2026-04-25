namespace coding.test;

public class Class169Test
{
    [Theory]
    [InlineData(new int[] {3, 2, 3}, 3)]
    [InlineData(new int[] {2, 2, 1, 1, 1, 2, 2}, 2)]
    [InlineData(new int[] {1, 1, 1, 2, 2, 2}, 1)]
    public void Test(int[] nums, int expectedResult)
    {
        // Act
        Class169 solution = new Class169();
        int actualResult = solution.MajorityElement(nums);

        Assert.Equal(expectedResult, actualResult);
    }
}