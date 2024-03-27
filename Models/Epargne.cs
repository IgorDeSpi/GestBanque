namespace Models;

public class Epargne : Compte
{
    private DateTime _dateDernierRetrait;

    public DateTime DateDernierRetrait
    {
        get
        {
            return _dateDernierRetrait;
        }
        private set
        {
            _dateDernierRetrait = value;
        }
    }

    public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
    {
    }

    public Epargne(string numero, Personne titulaire, double solde, DateTime dateDernierRetrait) : base(numero, titulaire, solde)
    {
        DateDernierRetrait = dateDernierRetrait;
    }

    public override void Retrait(double Montant)
    {
        double ancienSolde = Solde;
        base.Retrait(Montant);
        if (Solde != ancienSolde)
        {
            DateDernierRetrait = DateTime.Now;
        }
    }

    protected override double CalculInteret()
    {
        return Solde * .045;
    }
}
