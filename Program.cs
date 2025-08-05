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
                        Additional.HoldScreen();
                        break;
                    case '2':
                        int depositId = Validation.IntValidation("account id");
                        decimal depositAmount = Validation.DecimalValidation("deposit amount");
                        var accountToDeposit = service.GetAccountById(depositId);
                        if (accountToDeposit != null)
                        {
                            service.UpdateAccountBalance(depositId, accountToDeposit.Balance + depositAmount);
                            Console.WriteLine("Deposit successful.\n");
                            Additional.HoldScreen();
                        }
                        else
                        {
                            Console.WriteLine("Account not found.\n");
                            Additional.HoldScreen();
                        }
                        break;
                    case '3':
                        int withdrawId = Validation.IntValidation("account id");
                        decimal withdrawAmount = Validation.DecimalValidation("withdraw amount");
                        var accountToWithdraw = service.GetAccountById(withdrawId);
                        if (accountToWithdraw != null)
                        {
                            if (accountToWithdraw.Balance >= withdrawAmount)
                            {
                                service.UpdateAccountBalance(withdrawId, accountToWithdraw.Balance - withdrawAmount);
                                Console.WriteLine("Withdrawal successful.\n");
                                Additional.HoldScreen();
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance.\n");
                                Additional.HoldScreen();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Account not found.\n");
                            Additional.HoldScreen();
                        }
                        break;
                    case '4':
                        int showId = Validation.IntValidation("account id");
                        var accountToShow = service.GetAccountById(showId);
                        if (accountToShow != null)
                        {
                            Console.WriteLine($"Account ID: {accountToShow.Id}");
                            Console.WriteLine($"Holder Name: {accountToShow.HolderName}");
                            Console.WriteLine($"Balance: {accountToShow.Balance:C}\n");
                            Additional.HoldScreen();
                        }
                        else
                        {
                            Console.WriteLine("Account not found.\n");
                            Additional.HoldScreen();
                        }
                        break;
                    case '0':
                        Console.WriteLine("Exiting the system. Goodbye!");
                        Additional.HoldScreen();
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.\n");
                        Additional.HoldScreen();
                        break;
                }
            }
        }
    }
}
