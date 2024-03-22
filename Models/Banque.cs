namespace Models;

public class Banque
{
    public string Nom {  get; set; }

    private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();

    public Courant? this[string Numero]
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

    public void Ajouter(Courant compte)
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
        foreach (var index in _comptes)
        {
            Console.WriteLine($"Clé : {index.Key}, Titulaire: {index.Value.Titulaire.Prenom} {index.Value.Titulaire.Nom}.");
        }
    }
}
