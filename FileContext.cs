using BankSystem_LevelArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BankSystem_LevelArchitecture
{
    class FileContext
    {
        //file path ...
        private static string filePath = "accounts.json";
        //to load bank accounts from a file
        public static List<BankAccount> LoadAccounts()
        {
            if (!File.Exists(filePath))
                return new List<BankAccount>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<BankAccount>>(json) ?? new List<BankAccount>();
        }
        //to save bank accounts to a file
        public static void SaveAccounts(List<BankAccount> accounts)
        {
            var json = JsonSerializer.Serialize(accounts);
            File.WriteAllText(filePath, json);
        }
    }
}
