using Models;

namespace GestBanque;

class Program
{
    static void Main(string[] args)
    {
        Personne titulaire = new Personne()
        {
            Nom = "Doe",
            Prenom = "John",
            DateNaiss = new DateTime(1970, 1, 1)

        };
        
        Courant courant = new Courant()
        {
            Numero = "0000001",
            LigneDeCredit = 500,
            Titulaire = titulaire
        };
        Courant courant2 = new Courant()
        {
            Numero = "0000002",
            LigneDeCredit = 500,
            Titulaire = titulaire
        };

        //courant.Depot(-100);
        //courant.Depot(100);
        //courant.Retrait(-100);
        //courant.Retrait(100);
        //courant.Retrait(600);

        Banque banque = new Banque();

        banque.Ajouter(courant);
        banque.Ajouter(courant2);
        banque.Supprimer(courant.Numero);
    }
}
