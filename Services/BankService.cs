using BankSystem_LevelArchitecture.Models;
using BankSystem_LevelArchitecture.Repostries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_LevelArchitecture.Services
{
    class BankService
    {
        //to create a private field for the repository ...
        private readonly IBankAccountRepository _repository;
        //to create a constructor to initialize the repository ...
        public BankService(IBankAccountRepository repository)
        {
            _repository = repository;
        }
        //to get all accounts ...
        public List<BankAccount> GetAllAccounts()
        {
            return _repository.GetAllAccounts();
        }
        //to add new account ...
        public void CreateAccount(string name, decimal initialBalance)
        {
            var id = _repository.GetAllAccounts().Count + 1;
            var account = new BankAccount
            {
                Id = id,
                HolderName = name,
                Balance = initialBalance
            };

            _repository.AddAccount(account);
        }
        //to get account by id ...
        public BankAccount GetAccountById(int id)
        {
            return _repository.GetAccountById(id);
        }
        //to get account by holder name ...
        public BankAccount GetAccountByHolderName(string holderName)
        {
            return _repository.GetAccountByHolderName(holderName);
        }
        //to update account holder name ...
        public void UpdateAccountHolderName(int id, string newHolderName)
        {
            _repository.UpdateAccountHolderName(id, newHolderName);
        }
    }
}
