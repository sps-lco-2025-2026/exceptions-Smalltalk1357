// exercise 3
Console.Write("Enter a number: ");
try
{
    int n = int.Parse(Console.ReadLine()!);
    n = n % 2;
    if (n == 0)
    {
        Console.WriteLine("The number is even");
    }
    else
    {
        Console.WriteLine("The number is odd");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: The value you input is not a valid number")
}
catch (Exception)
{
    Console.WriteLine("Error: Something unexpected went wrong")
}
finally
{
    Console.WriteLine("Thank you for using the program")
}