namespace MathFigures.Tests.Circle;

using MathFigures;

public class CircleTests
{
    [Fact]
    public void Test_CreateCircle()
    {
        // Arrange
        double r = 2;

        // Act
        Circle circle = new(r);

        // Assert
        Assert.Equal(2, circle.R);
    }

    [Fact]
    public void Test_CreateCircle_NegativeRadius()
    {
        // Arrange
        double r = -2;

        // Assert
        Assert.ThrowsAny<Exception>(() => { new Circle(r); });
    }

    [Fact]
    public void Test_CreateCircle_ZeroRadius()
    {
        // Arrange
        double r = 0;

        // Assert
        Assert.ThrowsAny<Exception>(() => { new Circle(r); });
    }

    [Fact]
    public void Test_GetArea_1()
    {
        // Arrange
        double r = 2;
        Circle circle = new(r);

        // Act

        var area = circle.Area;

        // Assert
        Assert.True(Math.Abs(area - 12.56) < 0.01);
    }

    [Fact]
    public void Test_GetArea_2()
    {
        // Arrange
        double r = 100;
        Circle circle = new(r);

        // Act

        var area = circle.Area;

        // Assert
        Assert.True(Math.Abs(area - 31415.92) < 0.01);
    }
}
