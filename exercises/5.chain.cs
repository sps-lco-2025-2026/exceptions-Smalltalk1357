// dotnet run /Users/alexwan/Projects/exceptions-Smalltalk1357/exercises/5.chain.cs 
int Divide(int a, int b)
{
    int returnValue;
    try
    {
        return = a / b;
    }
    catch (DivideByZeroException)
    { 
        throw new ArgumentException("Denominator cannot be zero")
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
        Console.WriteLine("Error: ", e.message);
    }
}

Console.WriteLine(ReadAndDivide());