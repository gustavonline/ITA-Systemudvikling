namespace xUnitTest_Calculator;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(2, 2, 4)]
    [InlineData(3, 3, 6)]
    [InlineData(4, 4, 8)]
    
    public void Test1(int v1, int v2, int expected)
    {
        //Arrange
        var calculator = new Calculator.Expressions();
        
        //Act
        var output = calculator.Add(v1, v2);
        
        //Assert
        Assert.Equal(expected, output);
    }
}