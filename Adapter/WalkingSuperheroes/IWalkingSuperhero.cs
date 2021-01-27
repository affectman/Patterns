namespace Adapter.WalkingSuperheroes
{
    /// <summary>
    /// Супергерои, которые ходят.
    /// </summary>
    public interface IWalkingSuperhero
    {
        /// <summary>
        /// Имя супергероя.
        /// </summary>
        string Name { get;}

        /// <summary>
        /// Движение.
        /// </summary>
        void Move();

        /// <summary>
        /// Атакует.
        /// </summary>
        void Attack();
    }
}