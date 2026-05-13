// dotnet run /Users/alexwan/Projects/exceptions-Smalltalk1357/exercises/5.chain.cs 
int Divide(int a, int b)
{
    try
    {
        return a / b;
    }
    catch (DivideByZeroException ex)
    {
        throw new ArgumentException("Denominator cannot be zero", ex);
    }
}

int ReadAndDivide()
{
    Console.Write("Numerator: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Denominator: ");
    int b = int.Parse(Console.ReadLine()!);
    try
    {
        return Divide(a, b);
    }
    catch (ArgumentException e)
    {
        Console.Write("ArgumentException Error: ");
        Console.WriteLine(e.Message);
    }
    return 0;
}

Console.WriteLine("Return value: " + ReadAndDivide());