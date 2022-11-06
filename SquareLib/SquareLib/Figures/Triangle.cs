namespace SquareLib.Figures;

public class Triangle : IFigureBase
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateSquare()
    {
        var perimeter = CalculatePerimeter();

        return Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
    }

    public double CalculatePerimeter() => (SideA + SideB + SideC) / 2;

    public bool IsRectangular() => (SideA * SideA + SideB * SideB == SideC * SideC) ||
                                   (SideA * SideA + SideC * SideC == SideB * SideB) ||
                                   (SideC * SideC + SideB * SideB == SideA * SideA);
}