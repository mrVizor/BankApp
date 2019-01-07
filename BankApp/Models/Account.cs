using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Core.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal CurrentSum { get; set; }

        public int Percentage { get; set; }

        public AccountType Type { get; set; }
    }
}
