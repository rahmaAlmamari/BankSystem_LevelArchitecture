using BankSystem_LevelArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_LevelArchitecture.Repostries
{
    class BankAccountRepository
    {
        //to get all accounts ...
        public List<BankAccount> GetAllAccounts()
        {
            return FileContext.LoadAccounts();
        }

        //to add new account ...
        public void AddAccount(BankAccount account)
        {
            var accounts = GetAllAccounts();
            accounts.Add(account);
            FileContext.SaveAccounts(accounts);
        }

        //to get account by id ...
        public BankAccount GetAccount(int id)
        {
            return GetAllAccounts().FirstOrDefault(a => a.Id == id);
        }

        //to get account by holder name ...
        public BankAccount GetAccountByHolderName(string holderName)
        {
            return GetAllAccounts().FirstOrDefault(a => a.HolderName.Equals(holderName, StringComparison.OrdinalIgnoreCase));
        }

        //to update account holder name ...
        public void UpdateAccountHolderName(int id, string newHolderName)
        {
            var accounts = GetAllAccounts();
            var account = accounts.FirstOrDefault(a => a.Id == id);
            if (account != null)
            {
                account.HolderName = newHolderName;
                FileContext.SaveAccounts(accounts);
            }
        }

        //to update account balance ...
        public void UpdateAccountBalance(int id, decimal newBalance)
        {
            var accounts = GetAllAccounts();
            var account = accounts.FirstOrDefault(a => a.Id == id);
            if (account != null)
            {
                account.Balance = newBalance;
                FileContext.SaveAccounts(accounts);
            }
        }
    }
}
