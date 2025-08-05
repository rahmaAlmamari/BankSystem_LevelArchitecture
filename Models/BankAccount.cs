using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_LevelArchitecture.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string HolderName { get; set; }
        public decimal Balance { get; set; }
    }
}
