using Models;

namespace GestBanque;

class Program
{
    static void Main(string[] args)
    {
        Personne titulaire = new Personne()
        {
            Nom = "de Spirlet",
            Prenom = "Igor",
            DateNaiss = new DateTime(1998, 3, 15)

        };
        Courant courant = new Courant()
        {
            Numero = "0000001",
            LigneDeCredit = 500,
            Titulaire = titulaire
        };

        courant.Depot(-100);
        courant.Depot(100);
        courant.Retrait(-100);
        courant.Retrait(100);
        courant.Retrait(600);
    }
}
