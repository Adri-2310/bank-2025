namespace Adrien_mertens;

public class Bank
{
    private Dictionary<string, Account> _accounts = new Dictionary<string, Account>();
    
    public void AddAccount(Account account)
    {
        if (_accounts.ContainsKey(account.Number))
        {
            Console.WriteLine("Erreur : Un compte avec ce numéro existe déjà.");
            return;
        }
        
        _accounts.Add(account.Number, account);
        Console.WriteLine($"Compte {account.Number} ajouté avec succès.");
    }

    public void DeleteAccount(string number)
    {
        if (!_accounts.ContainsKey(number))
        {
            Console.WriteLine("Erreur : Aucun compte trouvé avec ce numéro.");
            return;
        }
        _accounts.Remove(number);
        Console.WriteLine($"Compte {number} supprimé avec succès.");
    }

    public double ReturnSoldeCurrentAccount(string number)
    {
        if (!_accounts.TryGetValue(number, out var account))
        {
            Console.WriteLine("Erreur : Aucun compte trouvé avec ce numéro.");
            return 0;
        }

        return account.Balance;
    }
    
    public void ShowAllCurrentAccounts()
    {
        Console.WriteLine("Liste des comptes :");
        foreach (var account in _accounts.Values)
        {
            Console.WriteLine(
                $"N°: {account.Number}, " +
                $"Solde: {account.Balance}");
        }
    }  
}