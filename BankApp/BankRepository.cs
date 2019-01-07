using BankApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Core
{
    public class BankRepository
    {
        AccountContext _db;

        public BankRepository(AccountContext context)
        {
            _db = context;

            if (!_db.Accounts.Any())
                 _db.Accounts.Add(new Account { CurrentSum = 600, Name = "Second Account", Percentage = 3 });
        }

        public async Task<List<Account>> GetAccounts()
        {
            var accounts = _db.Accounts.ToListAsync();
            return await accounts;
        }

        public async void CreateAccount(Account account)
        {
            if (account == null)
                return;
            await _db.Accounts.AddAsync(account);
            _db.SaveChanges();
        }
    }
}
