using MathFigures.Interfaces;

namespace MathFigures;

public abstract class Figure : IFigure
{
    public double Area => CalculateArea();

    protected abstract double CalculateArea();
}