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
        double oldSolde = Solde;
        base.Retrait(Montant);
        if (Solde != oldSolde)
        {
            DateDernierRetrait = DateTime.Now;
        }
    }
}
