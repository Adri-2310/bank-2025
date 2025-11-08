using System;
namespace Adrien_mertens;
/// <summary>
/// class pour la gestion d'un carnet d'épargne 
/// </summary>
public class SavingAccount : Account
{
    public SavingAccount(string number, Person owner, DateTime dateLastWithdraw) : base(number, owner)
    {
        DateLastWithdraw = dateLastWithdraw;
    }

    private DateTime DateLastWithdraw { get; set; }

    public override void WithDraw(double amount)
    {
        base.WithDraw(amount);
        DateLastWithdraw = DateTime.Now;
    }

    public override void Deposit(double amount)
    {
        base.Deposit(amount);
        DateLastWithdraw = DateTime.Now;
    }
}