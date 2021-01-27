using System;

namespace State
{
    /// <summary>
    /// Базовый статус.
    /// </summary>
    class StandardState : State
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="balance"> Баланс. </param>
        /// <param name="account"> Счет в банке. </param>
        public StandardState(double balance, BankAccount account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        /// <summary>
        /// Перегрузка конструктора.
        /// </summary>
        /// <param name="state"> Статус. </param>
        public StandardState(State state)
            : this(state.Balance, state.Account)
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }
        }

        /// <summary>
        /// Инициализировать условия статуса.
        /// </summary>
        private void Initialize()
        {
            Interest = 0.0;
            LowerLimit = 0.0;
            UpperLimit = 1000.0;
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
            if (Balance < LowerLimit)
            {
                Account.State = new BlackListState(this);
            }
            else if (Balance > UpperLimit)
            {
                Account.State = new GoldState(this);
            }
        }
    }
}
