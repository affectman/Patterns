using System;

namespace Adapter.WalkingSuperheroes
{
    /// <summary>
    /// Класс супергероя Росомахи.
    /// </summary>
    public class WolverineSuperhero : IWalkingSuperhero
    {
        /// <summary>
        /// Имя супергероя.
        /// </summary>
        public string Name => "Джеймс";

        /// <summary>
        /// Движение.
        /// </summary>
        public void Move()
        {
            Console.WriteLine("Бегает рысью");
        }

        /// <summary>
        /// Атакует.
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("Царапаюсь");
        }
    }
}
