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
                return;
            }
            _solde = value;
        } 
    }

    public double LigneDeCredit;
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

    }

    public void Depot(double Montant)
    {

    }
}
