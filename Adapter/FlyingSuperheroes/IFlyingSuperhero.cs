namespace Adapter.FlyingSuperheroes
{
    /// <summary>
    /// Летающие супергерои.
    /// </summary>
    public interface IFlyingSuperhero
    {
        /// <summary>
        /// Прозвище супергероя.
        /// </summary>
        string Nickname { get; }

        /// <summary>
        ///  Метод реализующий полет.
        /// </summary>
        void Fly();

        /// <summary>
        /// Атака.
        /// </summary>
        void Attack();

    }
}