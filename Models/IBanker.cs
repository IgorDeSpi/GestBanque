namespace Models;

public interface IBanker : ICustomer
{
    Personne Titulaire { get; }
    string Numero { get; }

    void AppliquerInteret();
}
