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
        //to create a private field for the repository
        private readonly IBankAccountRepository _repository;
        //to create a constructor to initialize the repository
        public BankService(IBankAccountRepository repository)
        {
            _repository = repository;
        }
    }
}
