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
            Numero = "00001",
            LigneDeCredit = 500,
            Titulaire = titulaire
        };
        Courant courant2 = new Courant()
        {
            Numero = "00002",
            LigneDeCredit = 500,
            Titulaire = titulaire
        };

        

        Banque banque = new Banque()
        {
            Nom = "Bruxelles Bruxelles vie"
        };
        
        banque.Ajouter(courant);
        banque.Ajouter(courant2);

        banque["00001"].Depot(-100);
        banque["00001"].Depot(100);
        banque["00001"].Retrait(-100);
        banque["00001"].Depot(100);
        banque["00001"].Retrait(600);

        banque.AfficherListe();
        Console.WriteLine($"Le solde du compte {banque["00001"].Numero} de la banque {banque.Nom} est : {banque["00001"].Solde}");
        banque.Supprimer(courant.Numero);
        banque.AfficherListe();
    }
}
