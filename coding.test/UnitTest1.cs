namespace coding.test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int a = 1;
        int b = 2;

        Class1 class1 = new Class1();
        int result = class1.Add(a, b);

        Assert.Equal(3, result);
    }
}
