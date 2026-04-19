namespace coding.test;

public class Class80Test
{
    [Theory]
    [InlineData(new int[] {1,1,1,2,2,3}, 5)]
    [InlineData(new int[] {0,0,1,1,1,1,2,3,3}, 7)]
    public void Test(int[] nums, int expectedResult){
        var result = new Class80().RemoveDuplicates(nums);
        Assert.Equal(expectedResult, result);
    }
}
