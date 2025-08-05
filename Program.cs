using BankSystem_LevelArchitecture.Repostries;

namespace BankSystem_LevelArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to create a new instance of the repository ...
            IBankAccountRepository repo = new BankAccountRepository();
            //to create a new instance of the service ...
            IBankService service = new BankService(repo);
        }
    }
}
