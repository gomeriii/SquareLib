using NUnit.Framework;
using SquareLib;

namespace Tests;

public class SquareExtensionsTests
{
    [TestCase(5d, ExpectedResult = 78.54d)]
    [TestCase(5d, 6d, 7d, ExpectedResult = 14.7d)]
    public double Check_Calculation_Square_Successful(params double[] args)
    {
        SquareExtensions.CalculateSquare(out var square, args);
        var roundedSquare = Math.Round(square, 2);

        return roundedSquare;
    }
}