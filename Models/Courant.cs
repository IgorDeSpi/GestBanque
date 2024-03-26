namespace Models;

public class Courant : Compte
{
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
                Console.WriteLine("Erreur, la ligne de crédit doit être strictement positive.");
                return;
            }
            _ligneDeCredit = value;
        }
    }

    public override void Retrait(double Montant)
    {
        Retrait(Montant, LigneDeCredit);
    }

    protected override double CalculInteret()
    {
        return Solde * ((Solde < 0) ? .0975 : .03);
    }
}
