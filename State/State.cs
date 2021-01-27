namespace State
{
    /// <summary>
    /// Состояние.
    /// </summary>
    public abstract class State

    {
        /// <summary>
        /// Банковский счет.
        /// </summary>
        public BankAccount Account { get; set; }

        /// <summary>
        /// Баланс.
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// Процент по статусу.
        /// </summary>
        protected double Interest { get; set; }

        /// <summary>
        /// Нижний лимит для статуса.
        /// </summary>
        protected double LowerLimit { get; set; }

        /// <summary>
        /// Верхний лимит для статуса.
        /// </summary>
        protected double UpperLimit { get; set; }


        /// <summary>
        /// Положить деньги на счет.
        /// </summary>
        /// <param name="amount"> Сумма. </param>
        public abstract void AddMoneyOnAccount(double amount);

        /// <summary>
        /// Снять деньги со счета.
        /// </summary>
        /// <param name="amount"> Сумма. </param>
        public abstract void WithdrawMoneyOnAccount(double amount);

        /// <summary>
        /// Получить проценты по вкладу.
        /// </summary>
        public abstract void GetInterestOnDeposit();
    }
}
