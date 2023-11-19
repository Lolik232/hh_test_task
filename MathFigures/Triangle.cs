using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace MathFigures;
public class Triangle : Figure
{
    private readonly double[] _sides = new double[3];

    public Triangle(double[] sides)
    {
        SetSides(sides);
    }

    public Triangle(double a, double b, double c) : this(new double[3] { a, b, c })
    { }

    public double A => _sides[0];
    public double B => _sides[1];
    public double C => _sides[2];

    public bool IsRightTriangle()
    {
        // a^2 + b^2 = c^2

        double ab2 = Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2);

        return ab2 == Math.Pow(_sides[2], 2);
    }

    protected override double CalculateArea()
    {
        // S = sqrt(p * (p - a)(p - b)(p - c));

        double p = _sides.Sum() / 2;
        double composition = p;

        foreach (var side in _sides)
        {
            composition *= (p - side);
        }

        return Math.Sqrt(composition);
    }

    private void SetSides(double[] sides)
    {
        Array.Sort(sides);

        CheckSides(sides);

        Array.Copy(sides, _sides, 3);
    }

    public static bool CanCreateTriangle(double a, double b, double c)
    {
        double[] sides = new double[3] { a, b, c };

        return CanCreateTriangle(sides);
    }
    public static bool CanCreateTriangle(double[] sides)
    {
        try
        {
            CheckSides(sides);
        }
        catch (Exception)
        {
            return false;
        }

        return true;
    }
    private static void CheckSides(double[] sides)
    {
        if (sides.Length != 3) throw new ArgumentOutOfRangeException(nameof(sides));

        if (!sides.All(x => x > 0)) throw new ArgumentException("Все длины сторон должны быть положительные"); ;

        if ((sides[0] + sides[1]) <= sides[2])
            throw new ArgumentException("Чтобы построить треугольник, сумма двух длин любых сторон должна быть больше третьей стороны");
    }
}
