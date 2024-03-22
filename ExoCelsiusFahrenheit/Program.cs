using ExoCelsiusFahrenheit;

namespace ExoCelsiusFarhrenheit;
class Program
{
    static void Main(string[] args)
    {
        Celsius celsius = new Celsius() 
        { 
            Temperature = -2
        };
        Console.WriteLine($"Température : {celsius.Temperature}°C");
        
        Fahrenheit fahrenheit = celsius;
        
        Console.WriteLine($"Température : {fahrenheit.Temperature}°F");
        
        celsius = (Celsius)fahrenheit;
        
        Console.WriteLine($"Température : {celsius.Temperature}°C");
    }
}
