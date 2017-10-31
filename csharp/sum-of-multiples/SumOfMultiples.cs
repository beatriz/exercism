using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var sum = 0;
        for (int num = 0; num < max; num++)
        {
            sum += IsMultiple(num, multiples) ? num : 0;
        }

        return sum;
    }
    
    private static bool IsMultiple(this int @this, IEnumerable<int> numbers)
    {
        foreach (var number in numbers)
        {
            if (@this % number == 0)
            {
                return true;
            }
        }

        return false;
    }
}