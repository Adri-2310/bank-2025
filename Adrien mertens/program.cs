using Adrien_mertens;

class Program
{
    static void Main()
    {
        // Exemple d'utilisation
        var bank = new Bank();
        var person = new Person("Adrien", "Mertens", new DateTime(2000, 10, 23));
        var account = new CurrentAccount("BE123456789", person, 1000);
        
        bank.AddAccount(account);
        account.Deposit(2000);
        account.WithDraw(100);
        Console.WriteLine($"le solde du compte {account.Number} est de {bank.ReturnSoldeCurrentAccount(account.Number)}");
        bank.ShowAllCurrentAccounts();
        
        bank.DeleteAccount(account.Number);
    }
    
}