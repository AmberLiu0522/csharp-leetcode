namespace coding.test;

public class Class88Test
{
    [Theory]
    [InlineData(new int[] {1, 2, 3, 0, 0, 0}, 3, new int[] {2, 5, 6}, 3, new int[] {1, 2, 2, 3, 5, 6})]
    [InlineData(new int[] {1}, 1, new int[] {}, 0, new int[] {1})]
    [InlineData(new int[] {0}, 0, new int[] {1}, 1, new int[] {1})]
    public void Test(int[] nums1, int m, int[] nums2, int n, int[] expectedResult)
    {
        // Act
        Class88 solution = new Class88();
        int[] actualResult = solution.MergeAndSort(nums1, m, nums2, n);

        Assert.Equal(expectedResult, actualResult);
    }
}
