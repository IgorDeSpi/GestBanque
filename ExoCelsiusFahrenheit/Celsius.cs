namespace ExoCelsiusFahrenheit;

public struct Celsius
{
    public static implicit operator Fahrenheit(Celsius valeur)
    {
        return new Fahrenheit()
        {
            Temperature = (valeur.Temperature * 1.8) + 32
        };
    }
    public double Temperature { get; set; }
}
