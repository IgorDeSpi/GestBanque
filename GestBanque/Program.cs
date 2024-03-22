using Models;

namespace GestBanque;

internal class Program
{
    static void Main(string[] args)
    {
        Personne titulaire = new Personne("de Spirlet", "Igor", new DateTime(1998, 3, 15));
        Courant courant = new Courant("0000001", 2, 15,titulaire);

        courant.Retrait(2);
        courant.Depot(5);
    }
}
