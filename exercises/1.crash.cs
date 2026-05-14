string[] names = { "Alice", "Bob", "Charlie" };
Console.Write("Enter an index: ");
try
{
    int i = int.Parse(Console.ReadLine()!);
    Console.WriteLine(names[i]);
}
catch (FormatException)
{
    Console.WriteLine("Error: The value you input is not a valid number");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Error: The index you input is out of range");
}
catch (Exception)
{
    Console.WriteLine("Error: Something unexpected went wrong");
}

