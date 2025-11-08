namespace Adrien_mertens;
/// <summary>
///  classe pour les comptes courants
/// </summary>
public class CurrentAccount : Account
{
    public CurrentAccount(string number, Person owner, double creditLine) : base(number, owner)
    {
        CreditLine = creditLine;
    }

    private double CreditLine { get; set; }
    
    
    public override void WithDraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Erreur : Le montant doit être positif");
            return;
        }

        if (Balance - amount < -CreditLine)
        {
            Console.WriteLine("Erreur : Le solde est insuffisant");
            return;
        }
        base.WithDraw(amount);
        Console.WriteLine($"Retrait de {amount} effectué avec succès.");
    }
    public override void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Erreur : le montant doit être positif");
            return;
        }

        base.Deposit(amount);
        Console.WriteLine($"Dépôt de {amount} effectué avec succès.");
    }
    
}