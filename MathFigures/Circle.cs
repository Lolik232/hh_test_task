namespace MathFigures;
public class Circle : Figure
{
    private double _radius;

    public double R => _radius;


    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException($"{nameof(radius)} должен быть больше 0");
        }

        _radius = radius;
    }

    protected override double CalculateArea()
    {
        // S = PI * R^2
        return Math.PI * Math.Pow(_radius, 2);
    }
}
