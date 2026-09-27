using LeetCode;
using LeetCode._0020_ValidParentheses;
using LeetCode._0066_PlusOne;

class Program
{
    public static void Main(){
        
        //0020-ValidParenthesis
        Console.WriteLine(ValidParenthesis.IsValid("({}[])"));
        
        //0066-PlusOne
        Console.WriteLine(string.Join(", ", PlusOne.Increment([9])));
    }
}