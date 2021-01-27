using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Isaev Vladislav", "Tinkoff");

            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            account.Withdraw(5000.00);
            account.PayInterest();

            Console.ReadKey();
        }
    }
}
