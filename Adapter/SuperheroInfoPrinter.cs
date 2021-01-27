using System;
using Adapter.WalkingSuperheroes;

namespace Adapter
{
    /// <summary>
    /// Вывод информации о супергерое.
    /// </summary>
    public class SuperheroInfoPrinter
    {
        /// <summary>
        /// Вывод на консоль информации о супергерое.
        /// </summary>
        /// <param name="hero">Супергерой.</param>
        public static void PrintSuperheroInfo(IWalkingSuperhero hero)
        {
            if (hero == null) throw new ArgumentNullException("Не найден супергерой",nameof(hero));
            Console.WriteLine($"Имя супергероя: {hero.Name}");
            Console.Write("Вид перемещения: ");
            hero.Move();
            Console.Write("Вид атаки: ");
            hero.Attack();
            Console.ReadKey();
        }
    }
}
