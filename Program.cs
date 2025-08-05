using BankSystem_LevelArchitecture.Helper;
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
                char choice = Validation.CharValidation("your option");

                switch (choice)
                {
                    case '1':
                        Console.Write("Name: ");
                        string name = Validation.StringNamingValidation("holder name");
                        Console.Write("Initial Balance: ");
                        decimal balance = Validation.DecimalValidation("initial balance");
                        service.CreateAccount(name, balance);
                        Console.WriteLine("Account created.\n");
                        break;
                }
            }
        }
    }
}
