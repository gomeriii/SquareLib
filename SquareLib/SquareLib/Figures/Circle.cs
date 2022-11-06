namespace SquareLib.Figures;

public class Circle : IFigureBase
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateSquare() => Math.PI * Math.Pow(Radius, 2);

    public double CalculatePerimeter()
    {
        throw new NotImplementedException();
    }
}