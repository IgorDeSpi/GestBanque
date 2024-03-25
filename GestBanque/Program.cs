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

        Epargne epargne = new Epargne()
        {
            Numero = "00003",
            Titulaire = titulaire
        };

        Banque banque = new Banque()
        {
            Nom = "Bruxelles Bruxelles vie"
        };
        
        banque.Ajouter(courant);
        banque.Ajouter(epargne);
        //banque.Ajouter(courant2);

        if (banque["00001"] is Courant c)
        {
            c.LigneDeCredit = -500;
        }

        banque["00001"].Depot(-100);
        banque["00001"].Depot(100);
        banque["00001"].Retrait(-100);
        banque["00001"].Depot(100);
        banque["00001"].Retrait(600);

        banque["00003"].Depot(300);
        banque["00003"].Retrait(100);
        banque["00003"].Retrait(300);

        //epargne.Depot(300);
        //epargne.Retrait(200);
        //epargne.Retrait(1200);

        Console.WriteLine($"\nDate du dernier retrait : {epargne.DateDernierRetrait}, solde du compte épargne : {epargne.Solde} euros \n");

        banque.AfficherListe();

        Console.WriteLine($"Le solde du compte {banque["00001"].Numero} de la banque {banque.Nom} est de {banque["00001"].Solde} euros.");
        
        Console.WriteLine($"Les avoirs de M. {titulaire.Prenom} {titulaire.Nom} sont de {banque.AvoirDesComptes(titulaire)} euros.");

        //banque.Supprimer(courant.Numero);
        banque.AfficherListe();

    }
}
