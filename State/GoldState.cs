using System;

namespace State
{
    /// <summary>
    /// Золотой статус.
    /// </summary>
    class GoldState : State
    {
        /// <summary>
        /// Перегрузка конструктора.
        /// </summary>
        /// <param name="state"> Статус. </param>
        public GoldState(State state)
            : this(state.Balance, state.Account)
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="balance"> Баланс. </param>
        /// <param name="account"> Счет в банке. </param>
        public GoldState(double balance, BankAccount account)
        {
            Account = account ?? throw new ArgumentNullException(nameof(account));
            Balance = balance;
            Initialize();
        }

        /// <summary>
        /// Инициализировать условия статуса.
        /// </summary>
        private void Initialize()
        {
            Interest = 0.05;
            LowerLimit = 1000.0;
            UpperLimit = 10000000.0;
        }

        /// <summary>
        /// Положить деньги на счет.
        /// </summary>
        /// <param name="amount"> Сумма. </param>
        public override void AddMoneyOnAccount(double amount)
        {
            Balance += amount;
            CheckStateChange();
        }

        /// <summary>
        /// Снять деньги со счета.
        /// </summary>
        /// <param name="amount"> Сумма. </param>
        public override void WithdrawMoneyOnAccount(double amount)
        {
            Balance -= amount;
            CheckStateChange();
        }

        /// <summary>
        /// Получить проценты по вкладу.
        /// </summary>
        public override void GetInterestOnDeposit()
        {
            Balance += Interest * Balance;
            CheckStateChange();
        }

        /// <summary>
        /// Проверка на изменение состояния.
        /// </summary>
        private void CheckStateChange()
        {
            if (Balance < 0.0)
            {
                Account.State = new BlackListState(this);
            }
            else if (Balance < LowerLimit)
            {
                Account.State = new StandardState(this);
            }
        }
    }
}
