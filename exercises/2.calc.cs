Console.Write("Enter a number: ");
try
{
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine(100 / n);
}
catch (FormatException)
{
    Console.WriteLine("Error: The value you input is not a valid number")
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: The value you input is zero, caused a division error")
}
catch (Exception)
{
    Console.WriteLine("Error: Something unexpected went wrong")
}
finally
{
    Console.WriteLine("Calculation complete.")
}