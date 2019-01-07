using BankApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Core
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        { }

        //private static readonly Lazy<AccountContext> lazy =
        //new Lazy<AccountContext>(() => new AccountContext());

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(Constants.ConnectionString);
        //}

        //public static AccountContext GetInstance()
        //{
        //    return lazy.Value;
        //}
    }
}
