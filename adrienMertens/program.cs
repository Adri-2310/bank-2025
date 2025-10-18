class Person
{
    public string FirstName { get;set };
    public string LastName { get;set };
    public DateTime BirthDate { get;set };

    public Person(string firstName, string lastName, DateTime birthDate)
    {
        firstName = firstName;
        lastName = lastName;
        birthDate = birthDate;
    }
}

class CurrentAccount
{
    private string number;
    private double readonly balance;
    private double creditLine;
    private Person owner;

    public void WithDraw(double amount)
    {
        
    }
    public void Deposit(double amount)
    {
        
    }
}

class Bank
{
    private readonly Dictionary<string, CurrentAccount> _accounts
    private string name;
    
    public void AddAccount(CurrentAccount account)
    {
        
    }

    public void DeleteAccount(string number)
    {
        
    }

    public double ReturnSoldeCurrentAccount()
    {
        
    }
    public void ShowAllCurrentAccounts()
    {
        
    }
}

class Program
{
    // Exemple d'utilisation
    var bank = new Bank("Ma Banque");
    var person = new Person("Adrien", "Mertens", new DateTime(1990, 1, 1));
    var account = new CurrentAccount("BE123456789", person, 1000);
}
