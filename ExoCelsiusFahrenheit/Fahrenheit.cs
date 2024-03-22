namespace ExoCelsiusFahrenheit;

public struct Fahrenheit
{
    public static explicit operator Celsius(Fahrenheit valeur)
    {
        return new Celsius()
        {
            Temperature = (valeur.Temperature - 32) / 1.8
        };
    }
    public double Temperature { get; set; }
}
