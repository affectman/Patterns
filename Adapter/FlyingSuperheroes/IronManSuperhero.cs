using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.FlyingSuperheroes
{
    /// <summary>
    /// Класс железного человека.
    /// </summary>
    public class IronManSuperhero : IFlyingSuperhero
    {
        /// <summary>
        /// Прозвище супергероя.
        /// </summary>
        public string Nickname => "Tony";

        /// <summary>
        /// Метод реализующий полет.
        /// </summary>
        public void Fly()
        {
            Console.WriteLine("Взлетаю до небес.");
        }

        /// <summary>
        /// Атакует.
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("Стреляю ракетой.");
        }
    }
}
