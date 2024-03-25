﻿namespace Models;

public class Banque
{
    public string Nom {  get; set; }

    private Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>();

    public Compte? this[string Numero]
    {
        get
        {
            if (!_comptes.ContainsKey(Numero))
            {
                return null;
            }
            return _comptes[Numero];
        }
    }

    public void Ajouter(Compte compte)
    {
        _comptes.Add(compte.Numero, compte);
    }

    public void Supprimer(string Numero)
    {
        if (!_comptes.ContainsKey(Numero))
            return;
        _comptes.Remove(Numero);
    }

    public void AfficherListe()
    {
        Console.WriteLine("Voici la liste des comptes actuels dans la banque :");
        foreach (var compte in _comptes)
        {
            Console.WriteLine($"Numéro de compte : {compte.Key}, Titulaire: {compte.Value.Titulaire.Prenom} {compte.Value.Titulaire.Nom}.");
        }
    }

    public double AvoirDesComptes(Personne titulaire)
    {
        double total = 0D;

        foreach (Compte compte in _comptes.Values)
        {
            if (compte.Titulaire == titulaire)
            {
                total += compte;
            }
        }
        return total;
    }
}
