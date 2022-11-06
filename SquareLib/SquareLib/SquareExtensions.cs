using SquareLib.Figures;

namespace SquareLib;

public static class SquareExtensions
{
    public static bool CalculateSquare(out double square, params double[] args)
    {
        switch (args.Length)
        {
            case 1:
                square = new Circle(args[0]).CalculateSquare();
                return true;
            case 3:
                square = new Triangle(args[0], args[1], args[2]).CalculateSquare();
                return true;
        }

        square = 0;
        return false;
    }
}