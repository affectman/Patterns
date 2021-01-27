using System;

namespace State
{
    /// <summary>
    /// Статус "Черный список".
    /// </summary>
    public class BlackListState : State
    {
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="state"> Состояние. </param>
        public BlackListState(State state)
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }
            Balance = state.Balance;
            Account = state.Account;
            Initialize();
        }

        /// <summary>
        /// Инициализировать условия статуса.
        /// </summary>
        private void Initialize()
        {
            Interest = 0.0;
            LowerLimit = -100.0;
            UpperLimit = 0.0;
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
            Console.WriteLine("Нет денег для вывода! \n");
        }

        /// <summary>
        /// Получить проценты по вкладу.
        /// </summary>
        public override void GetInterestOnDeposit()
        {
            Console.WriteLine("По данному вкладу нет процентов!");
        }

        /// <summary>
        /// Проверка на изменение состояния.
        /// </summary>
        private void CheckStateChange()
        {
            if (Balance > UpperLimit)
            {
                Account.State = new StandardState(this);
            }
        }
    }
}
