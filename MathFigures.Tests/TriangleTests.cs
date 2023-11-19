namespace MathFigures.Tests.Triangle;

using MathFigures;

public class TriangleTests
{
    [Fact]
    public void Test_CreateTriangle()
    {
        // Arrange

        double a = 2;
        double b = 2;
        double c = 3;

        // Act

        Triangle triangle = new(a, b, c);

        // Assert
        Assert.Equal(2, triangle.A);
        Assert.Equal(2, triangle.B);
        Assert.Equal(3, triangle.C);
    }

    [Fact]
    public void Test_CreateTriangle_ZeroSide()
    {
        // Arrange
        double a = 0;
        double b = 2;
        double c = 3;

        // Assert
        Assert.ThrowsAny<Exception>(() => new Triangle(a, b, c));
    }

    [Fact]
    public void Test_CreateTriangle_InvalidSides()
    {
        // Arrange

        double a = 1;
        double b = 2;
        double c = 3;

        // Act
        Assert.ThrowsAny<Exception>(() => { new Triangle(a, b, c); });
    }

    [Fact]
    public void Test_CreateTriangleException_SidesSize()
    {
        // Arrange

        var sides = new double[4] { 1f, 2f, 3f, 4f };

        // Act
        Assert.ThrowsAny<Exception>(() => { new Triangle(sides); });
    }

    [Fact]
    public void Test_IsRightTriangle_Right()
    {
        // Arrange

        double a = 3;
        double b = 4;
        double c = 5;

        Triangle triangle = new(a, b, c);


        // Act
        var isRight = triangle.IsRightTriangle();

        // Assers

        Assert.True(isRight);
    }

    [Fact]
    public void Test_IsRightTriangle_NotRight()
    {
        // Arrange

        double a = 3;
        double b = 3;
        double c = 5;

        Triangle triangle = new(a, b, c);


        // Act
        var isRight = triangle.IsRightTriangle();

        // Assers

        Assert.False(isRight);
    }

    [Fact]
    public void Test_Area_1()
    {
        // Arrange

        double a = 3;
        double b = 3;
        double c = 3;

        Triangle triangle = new(a, b, c);


        // Act
        var area = triangle.Area;

        // Assers

        Assert.True(Math.Abs(area - 3.897) < 0.01);
    }


    [Fact]
    public void Test_Area_2()
    {
        // Arrange
        double a = 30;
        double b = 50;
        double c = 40;

        Triangle triangle = new(a, b, c);


        // Act
        var area = triangle.Area;

        // Assers

        Assert.True(Math.Abs(area - 600) < 0.0001);
    }
}
