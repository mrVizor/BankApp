using System;
using System.Collections.Generic;
using BankApp.Core;
using BankApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace BankApp.UI
{
     class Program
    {

        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddDbContext<AccountContext>(builder => builder.UseSqlServer(Constants.ConnectionString));
            var serviceProvider = services.BuildServiceProvider();

            BankRepository repository = new BankRepository(serviceProvider.GetService<AccountContext>());

            List<Account> accounts = repository.GetAccounts().Result;

            Console.WriteLine("1 - create Account; 2 - Exit");

            string command = Console.ReadLine();

            switch (int.Parse(command))
            {
                case 1 :
                    {
                        Console.WriteLine("Inter Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Inter Percentage");
                        string percentage = Console.ReadLine();

                        repository.CreateAccount(new Account { Name = name, Percentage = int.Parse(percentage) });
                    }
                    break;
                case 2 : break;
            }

            foreach (var a in accounts)
            {
                Console.WriteLine(a.Name);
            }

            Console.ReadKey();
        }
    }
}
