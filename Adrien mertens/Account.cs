namespace Adrien_mertens;

/// <summary>
/// Classe pour les comptes
/// </summary>
public class Account
{
    public string Number { get; set; }
    public double Balance { get; private set; }
    public Person Owner { get; set; }
    public Account(string number, Person owner)
    {
        Number = number;
        Owner = owner;
    }
    
    /// <summary>
    /// Méthode pour le retrait de fonds
    /// </summary>
    /// <param name="amount"></param>
    public virtual void WithDraw(double amount)
    {
        Balance -= amount;
    }
    
    /// <summary>
    /// Méthode pour déposer de fonds
    /// </summary>
    /// <param name="amount"></param>
    public virtual void Deposit(double amount)
    {
        Balance += amount;
    }

    
    
}