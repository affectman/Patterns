using System;

namespace State
{
    /// <summary>
    /// Банковский счет.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Статус.
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// Владелец счета.
        /// </summary>
        private string _owner;
        
        /// <summary>
        /// Название банка.
        /// </summary>
        private string _accountName;

        /// <summary>
        /// Конструктор счета в банке.
        /// </summary>
        /// <param name="owner"> Владелец счета.</param>
        /// <param name="accountName"> Название банка. </param>
        public BankAccount(string owner, string accountName)
        {
            _owner = owner ?? throw new ArgumentNullException(nameof(owner));
            _accountName = accountName ?? throw new ArgumentNullException(nameof(accountName));
            State = new StandardState(0.0, this);
        }

        /// <summary>
        /// Баланс.
        /// </summary>
        public double Balance => State.Balance;

        /// <summary>
        /// Пополнение вклада.
        /// </summary>
        /// <param name="amount"> Сумма. </param>
        public void Deposit(double amount)
        {
            State.AddMoneyOnAccount(amount);
            Console.WriteLine($"Внесено на вклад: {amount}");
            Console.WriteLine($"На счету: {Balance}");
            Console.WriteLine($"Статус: {State.GetType().Name}");
            Console.WriteLine("");
        }

        /// <summary>
        /// Снятие со денег со счета.
        /// </summary>
        /// <param name="amount"> Сумма. </param>
        public void Withdraw(double amount)
        {
            State.WithdrawMoneyOnAccount(amount);
            if (State.GetType().Name != "BlackListState")
            {
                Console.WriteLine($"Снятие со счета: {amount}");
            }
            Console.WriteLine($"На счету: {Balance}");
            Console.WriteLine($"Статус : {State.GetType().Name}");
            
        }

        /// <summary>
        /// Получить процент по вкладу.
        /// </summary>
        public void PayInterest()
        {
            State.GetInterestOnDeposit();
            if (State.GetType().Name == "BlackListState")
            {
                return;
            }
            Console.WriteLine($"Получен процент по вкладу");
            Console.WriteLine($"На счету: {Balance}");
            Console.WriteLine($"Статус : {State.GetType().Name}");
            Console.WriteLine("");
        }
    }
}
