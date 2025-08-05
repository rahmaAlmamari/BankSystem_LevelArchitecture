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
    }
}
