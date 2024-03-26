namespace Models;

public interface _IBanker : ICustomer
{
    Personne Titulaire { get; }
    string Numero { get; }
    double LigneDeCredit { get; set; }
    void AppliquerInteret();
}
