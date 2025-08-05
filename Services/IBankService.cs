using BankSystem_LevelArchitecture.Models;

namespace BankSystem_LevelArchitecture.Services
{
    public interface IBankService
    {
        void CreateAccount(string name, decimal initialBalance);
        void DeleteAccountById(int id);
        void DeleteAccountByHolderName(string holderName);
        BankAccount GetAccountByHolderName(string holderName);
        BankAccount GetAccountById(int id);
        List<BankAccount> GetAllAccounts();
        void UpdateAccountBalance(int id, decimal newBalance);
        void UpdateAccountHolderName(int id, string newHolderName);

    }
}