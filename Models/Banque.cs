namespace Models;

public class Banque
{
    private string _nom;

    private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();

    public string Nom
    {
        get
        {
            return _nom;
        }
        set
        {
            _nom = value;
        }
    }

    public Courant this[string Numero]
    {
        get
        {
            return _comptes[Numero];
        }
    }

    public void Ajouter(Courant compte)
    {
        _comptes.Add(compte.Numero, compte);
        Console.WriteLine("Voici la liste des comptes actuels dans la banque :");
        foreach (var index in _comptes)
        {
            Console.WriteLine($"Clé : {index.Key}, Titulaire : {index.Value.Titulaire.Nom}.");
        }
    }

    public void Supprimer(string Numero)
    {
        _comptes.Remove(Numero);
        Console.WriteLine("Voici la liste des comptes actuels dans la banque :");
        foreach (var index in _comptes)
        {
            Console.WriteLine($"Clé : {index.Key}, Titulaire: {index.Value.Titulaire.Nom}.");
        }
    }
}
