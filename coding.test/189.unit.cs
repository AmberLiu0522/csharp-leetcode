namespace coding.test;

public class Class189Test
{
    [Theory]
    [InlineData(new int[] {1,2,3,4,5,6,7}, 3, new int[] {5,6,7,1,2,3,4})]
    [InlineData(new int[] {-1,-100,3,99}, 2, new int[] {3,99,-1,-100})]
    public void Test(int[] nums, int k, int[] expectedResult)
    {
        // Act
        Class189 solution = new Class189();
        int[] actualResult = solution.Rotate(nums, k);

        Assert.Equal(expectedResult, actualResult);
    }
}