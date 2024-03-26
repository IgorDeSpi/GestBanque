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
