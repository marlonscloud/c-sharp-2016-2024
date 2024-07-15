namespace c_sharp_2016_2024;

//Version 6.0, released with Visual Studio 2015, released many smaller features that made C# programming more productive. 
//If you look at these features together, you see an interesting pattern.
//In this version, C# started to eliminate language boilerplate to make code more terse and readable.
//So for fans of clean, simple code, this language version was a huge win.

public static class Version6
{
    /// <summary>
    /// Produces the name of a variable, type, or member as the string constant. The produced name is not fully qualified.
    /// </summary>
    public static void NameOfOperator()
    {
        Console.WriteLine(nameof(System.Collections.Generic));  // output: Generic
        Console.WriteLine(nameof(List<int>));  // output: List
        Console.WriteLine(nameof(List<int>.Count));  // output: Count
        Console.WriteLine(nameof(List<int>.Add));  // output: Add

        List<int> numbers = [1, 2, 3];
        Console.WriteLine(nameof(numbers));  // output: numbers
        Console.WriteLine(nameof(numbers.Count));  // output: Count
        Console.WriteLine(nameof(numbers.Add));  // output: Add
    }
}
