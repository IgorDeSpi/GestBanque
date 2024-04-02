namespace Models;

public abstract class Compte : ICustomer, IBanker
{
    public static double operator +(double soldePrecedent, Compte courant)
    {
        return ((soldePrecedent < 0) ? 0 : soldePrecedent) + ((courant.Solde < 0) ? 0 : courant.Solde);
    }

    public event Action<Compte> PassageEnNegatifEvent;

    private string _numero;
    private double _solde;
    private Personne _titulaire;

    public string Numero
    {
        get
        {
            return _numero;
        }
        private set
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

    public Personne Titulaire
    {
        get
        {
            return _titulaire;
        }
        private set
        {
            _titulaire = value;
        }
    }

    public Compte(string numero, Personne titulaire)
    {
        Numero = numero;
        Titulaire = titulaire;
    }

    public Compte(string numero, Personne titulaire, double solde) : this(numero, titulaire)
    {
        Solde = solde;
    }

    public void Depot(double Montant)
    {
        if (Montant <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(Montant), "La valeur doit être supérieure à 0!");
        }
        else
        {
            Solde += Montant;
            Console.WriteLine($"Voici votre solde après le dépôt de {Montant} euros sur votre compte : {Solde} euros.");
        }
    }

    public virtual void Retrait(double Montant)
    {
        Retrait(Montant, 0D);
    }

    protected void Retrait(double Montant, double LigneDeCredit)
    {
        if (Montant <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(Montant), "La valeur doit être supérieure à 0!");
        }
        else if (Solde - Montant < -LigneDeCredit)
        {
            throw new SoldeInsuffisantException("Solde insuffisant!");
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

    protected void RaisePassageEnNegatifEvent()
    {
        PassageEnNegatifEvent?.Invoke(this);
    }
}