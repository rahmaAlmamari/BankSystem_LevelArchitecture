using BankSystem_LevelArchitecture.Models;

namespace BankSystem_LevelArchitecture.Repostries
{
    public  interface IBankAccountRepository
    {
        void AddAccount(BankAccount account);
        void DeleteAccount(int id);
        void DeleteAccountByHolderName(string holderName);
        BankAccount GetAccountByHolderName(string holderName);
        BankAccount GetAccountById(int id);
        List<BankAccount> GetAllAccounts();
        void UpdateAccountBalance(int id, decimal newBalance);
        void UpdateAccountHolderName(int id, string newHolderName);
    }
}