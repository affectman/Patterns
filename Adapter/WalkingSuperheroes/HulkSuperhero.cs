using System;

namespace Adapter.WalkingSuperheroes
{
    /// <summary>
    /// Класс супергероя Халка.
    /// </summary>
    public class HulkSuperhero : IWalkingSuperhero
    {
        /// <summary>
        /// Имя супергероя.
        /// </summary>
        public string Name => "Robert";

        /// <summary>
        /// Движение.
        /// </summary>
        public void Move()
        {
            Console.WriteLine("Бег трусцой");
        }

        /// <summary>
        /// Атакует.
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("Крушить!");
        }
    }
}
