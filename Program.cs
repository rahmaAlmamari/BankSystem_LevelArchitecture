using BankSystem_LevelArchitecture.Repostries;
using BankSystem_LevelArchitecture.Services;

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
            //to create the project menu ...
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Bank System");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Show Account");
                Console.WriteLine("0. Exit");
                Console.Write("Choose option: ");
            }
        }
    }
}
