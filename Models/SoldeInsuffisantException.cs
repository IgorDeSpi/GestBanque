namespace Models;

public class SoldeInsuffisantException : Exception
{
    public SoldeInsuffisantException(string message) : base(message)
    {
    }
}
