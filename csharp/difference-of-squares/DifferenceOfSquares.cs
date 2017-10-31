using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var sum = 0;
        for (int num = 0; num <= max; num++)
        {
            sum += num;
        }

        return (int)Math.Pow(sum, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        double sumOfSquares = 0;
        for (int num = 0; num <= max; num++)
        {
            sumOfSquares += Math.Pow(num, 2);
        }

        return (int)sumOfSquares;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}