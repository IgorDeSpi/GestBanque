namespace Models;

public abstract class _Compte : ICustomer, _IBanker
{
    public static double operator +(double soldePrecedent, _Compte courant)
    {
        return ((soldePrecedent < 0) ? 0 : soldePrecedent) + ((courant.Solde < 0) ? 0 : courant.Solde);
    }

    private string _numero;
    private double _solde;
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

    public double Solde
    {
        get
        {
            return _solde;
        }
        private set
        {
            _solde = value;
        }
    }

    public virtual double LigneDeCredit
    {
        get { return 0D; }
        set { return; }
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

    public virtual void Retrait(double Montant)
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

    protected abstract double CalculInteret();

    public void AppliquerInteret()
    {
        Solde += CalculInteret();
    }
}