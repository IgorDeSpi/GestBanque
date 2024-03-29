namespace ExoDelegate;

class Program
{
    static void Main(string[] args)
    {
        Voiture v1 = new Voiture("AA-123-AA");
        Voiture v2 = new Voiture("BB-456-BB");

        Carwash carwash = new Carwash();

        carwash.Traiter(v1);
        carwash.Traiter(v2);
    }
}
