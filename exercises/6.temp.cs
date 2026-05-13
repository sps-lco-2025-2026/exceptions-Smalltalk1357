class TemperatureException : Exception
{
    // your constructors here
    public TemperatureException(string message ) : base(message) { }
    public TemperatureException(string message, Exception innerException) : base(message, innerException) { }
}

class AbsoluteZeroException : TemperatureException
{
    decimal AbsoluteZero = -273.15m;
}

// program below...

const decimal absoluteZero = -273.15m;
// C -> F: (C * 9/5) + 32 = F

decimal celciusTemp;
decimal fahrenheitTemp;

Console.Write("Enter temperature in Celcius: ");

try
{
    celciusTemp = decimal.Parse(Console.ReadLine()!);
    
    if (celciusTemp < -273.15m)
    {
        throw new TemperatureException("Temperature cannot be below absolute zero (-273.15°C)");
    }
}