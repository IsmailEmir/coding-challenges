using LeetCode;
using LeetCode.Easy._0020_ValidParentheses;
using LeetCode.Easy._0035_SearchInserPosition;
using LeetCode.Easy._0066_PlusOne;

class Program
{
    public static void Main(){
        
        //0020-ValidParenthesis
        Console.WriteLine(ValidParenthesis.IsValid("({}[])"));
        
        //0035-SerachInsertPosition
        Console.WriteLine(SearchInsertPosition.SearchInsert([1,3,6,7,9], 0));
        
        //0066-PlusOne
        Console.WriteLine(string.Join(", ", PlusOne.Increment([9])));
        
        
    }
}