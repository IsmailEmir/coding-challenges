namespace LeetCode._0066_PlusOne;

public class PlusOne
{
    public static int[] Increment(int[] digits)
    {
        if (digits.Length == 0) return [];
        
        digits[^1]++;
        int index = digits.Length - 1;

        if (digits[0] == 10) return [1, 0];
        
        while (digits[index] == 10 && index > 0)
        {
            
            
            digits[index] = 0;
            digits[index-1]++;
            index--;

            if (digits[0] == 10)
            {
                var result = new int[digits.Length+1];
                result[0] = 1;
                return result;
            }
        }
        
        return digits;
    }
}