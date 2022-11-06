using NUnit.Framework;
using SquareLib.Figures;

namespace Tests;

public class TriangleTests
{
    [Test]
    public void Check_Calculation_Square_Successful()
    {
        double a = 5, b = 6, c = 7;

        var triangle = new Triangle(a, b, c);

        var roundedSquare = Math.Round(triangle.CalculateSquare(), 3);

        Assert.AreEqual(roundedSquare, 14.697);
    }

    [Test]
    public void Check_Triangle_Is_Rectangular_Successful()
    {
        var triangleA = new Triangle(5, 6, 7);
        var triangleB = new Triangle(21, 20, 29);

        Assert.AreEqual(triangleA.IsRectangular(), false);
        Assert.AreEqual(triangleB.IsRectangular(), true);
    }
}