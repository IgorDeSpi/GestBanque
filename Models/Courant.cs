using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public class Courant
{
    public string Numero;

    private double _solde;
    public double Solde 
    { 
        get
        {
            return _solde;
        }
        private set
        {
            if (value < 0)
            {
                Console.WriteLine("Erreur, le solde ne peut pas être négatif.");
                return;
            }
            _solde = value;
        } 
    }

    private double _ligneDeCredit;
    public double LigneDeCredit
    {
        get
        {
            return _ligneDeCredit;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Erreur, la ligne de crédit est strictement positive.");
                return;
            }
            _ligneDeCredit = value;
        }
    }

    public Personne Titulaire;

    public Courant(string numero, double solde, double ligneDeCredit, Personne titulaire)
    {
        Numero = numero;
        Solde = solde;
        LigneDeCredit = ligneDeCredit;
        Titulaire = titulaire;
    }

    public void Retrait(double Montant)
    {
        double oldSolde = Solde;
        if (Montant < 0)
        {
            Console.WriteLine("Vous tentez de faire un dépôt?");
        }
        else if ((oldSolde -= Montant) < LigneDeCredit)
        {
            Console.WriteLine($"Retrait impossible, solde insuffisant. Solde actuel : {Solde} euros.");
        }
        else
        {
            Solde -= Montant;
            Console.WriteLine($"Voici votre solde après le retrait de {Montant} euros de votre compte : {Solde} euros.");
        }

    }

    public void Depot(double Montant)
    {
        if (Montant  < 0)
        {
            Console.WriteLine("Vous tentez de faire un retrait?");
        }
        else
        {
            Solde = Solde + Montant;
            Console.WriteLine($"Voici votre solde après le dépôt de {Montant} euros sur votre compte : {Solde} euros.");
        }
    }
}
