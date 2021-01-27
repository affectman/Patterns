using System;
using Adapter.FlyingSuperheroes;
using Adapter.WalkingSuperheroes;

namespace Adapter.Adapters
{
    /// <summary>
    /// Адаптер от летающего к ходячему супергерою.
    /// </summary>
    public class FlyingSuperheroAdapter : IWalkingSuperhero
    {
        /// <summary>
        /// Летающий супергерой.
        /// </summary>
        private readonly IFlyingSuperhero _flyingSuperhero;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="flyingSuperhero"> Летающий супергерой.</param>
        public FlyingSuperheroAdapter(IFlyingSuperhero flyingSuperhero)
        {
            _flyingSuperhero = flyingSuperhero ?? throw new ArgumentNullException("Не передан супергерой", nameof(flyingSuperhero));
        }

        /// <summary>
        /// Имя супергероя.
        /// </summary>
        public string Name => _flyingSuperhero.Nickname;


        /// <summary>
        /// Движение.
        /// </summary>
        public void Move()
        {
            _flyingSuperhero.Fly();
        }

        /// <summary>
        /// Атакует.
        /// </summary>
        public void Attack()
        {
            _flyingSuperhero.Attack();
        }
    }
}