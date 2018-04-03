﻿using System.Data.Entity;
using Bank.Domain.Entities;

namespace Bank.Domain.Concrete
{
    public class EFDbContext: DbContext
    {
        public DbSet<BankAccount> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}