namespace Command
{
    /// <summary>
    /// Абстрактный класс команд.
    /// </summary>
    abstract class Command
    {
        /// <summary>
        /// Выполнить операцию.
        /// </summary>
        public abstract void Execute();

        /// <summary>
        /// Отменить операцию.
        /// </summary>
        public abstract void UnExecute();
    }
}
