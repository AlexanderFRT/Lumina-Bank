﻿namespace Lumina_Backend.Models;

public class Account : BaseEntity
{
    public int UserID { get; set; }
    public virtual User User { get; set; }

    public AccountType Type { get; set; }
    public decimal Balance { get; set; }
    public int AccountNumber { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; }
}

public enum AccountType
{
    Checking,
    Savings
}