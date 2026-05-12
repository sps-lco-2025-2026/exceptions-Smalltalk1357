// Snippet A
try
{
    int[] arr = new int[3];
    arr[10] = 5;
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Error: Index out of range");
}
catch (Exception)
{
    Console.WriteLine("Something unexpected went wrong");   
}

// Snippet B
try
{
    string s = null!;
    Console.WriteLine(s.Length);
}
catch (NullReferenceException)
{
    Console.WriteLine("Error: attempted operation on null reference");
}
catch (Exception)
{
    Console.WriteLine("Something unexpected went wrong");   
}

// Snippet C
try
{
    int x = int.MaxValue;
    checked
    {
        x = x + 1;
    } // checked enforces overflow detection
}
catch (OverflowException)
{
    Console.WriteLine("Error: Overflow detected");
}
catch (Exception)
{
    Console.WriteLine("Something unexpected went wrong");   
}