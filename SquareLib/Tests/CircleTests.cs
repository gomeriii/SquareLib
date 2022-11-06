using NUnit.Framework;
using SquareLib.Figures;

namespace Tests;

public class CircleTests
{
    [Test]
    public void Check_Calculation_Square_Successful()
    {
        double radius = 5;

        var circle = new Circle(radius);

        var roundedSquare = Math.Round(circle.CalculateSquare(), 2);

        Assert.AreEqual(roundedSquare, 78.54);
    }
}