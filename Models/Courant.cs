namespace Models;

public class Courant
{
    private string _numero;
    private double _solde;
    private double _ligneDeCredit; 
    private Personne _titulaire;

    public string Numero
    {
        get
        {
            return _numero;
        }
        set
        {
            _numero = value;
        }
    }

    public Personne Titulaire
    {
        get
        {
            return _titulaire;
        }
        set
        {
            _titulaire = value;
        }
    }

    public double Solde
    {
        get
        {
            return _solde;
        }
        private set
        {
            if (value < -LigneDeCredit)
            {
                Console.WriteLine("Erreur, le solde ne peut pas être inférieur à la limite négative de votre compte.");
                return;
            }
            _solde = value;
        }
    }

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

    public void Retrait(double Montant)
    {
        if (Montant <= 0)
        {
            Console.WriteLine("Vous tentez de faire un dépôt?");
            return;
        }
        else if (Solde - Montant < -LigneDeCredit)
        {
            Console.WriteLine($"Retrait impossible, solde insuffisant. Solde actuel : {Solde} euros.");
            return;
        }
        else
        {
            Solde -= Montant;
            Console.WriteLine($"Voici votre solde après le retrait de {Montant} euros de votre compte : {Solde} euros.");
        }

    }

    public void Depot(double Montant)
    {
        if (Montant <= 0)
        {
            Console.WriteLine("Vous tentez de faire un retrait?");
            return;
        }
        else
        {
            Solde += Montant;
            Console.WriteLine($"Voici votre solde après le dépôt de {Montant} euros sur votre compte : {Solde} euros.");
        }
    }
}
