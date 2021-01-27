using System;

namespace Iterator
{
    /// <summary>
    /// Конкретный итератор.
    /// </summary>
    /// <typeparam name="T">Тип элементов коллекции.</typeparam>
    public class Iterator<T> : IIterator<T>
    {
        /// <summary>
        /// Коллекция для перебора.
        /// </summary>
        private readonly IAggregate<T> _aggregate;

        /// <summary>
        /// Текущий индекс.
        /// </summary>
        private int _current = 0;

        /// <summary>
        /// Конструктор создания итератора.
        /// </summary>
        /// <param name="aggregate">Коллекция для перебоа.</param>
        public Iterator(IAggregate<T> aggregate)
        {
            _aggregate = aggregate ?? throw new ArgumentNullException(nameof(aggregate));
        }

        /// <summary>
        /// Получить первый элемент.
        /// </summary>
        /// <returns>Первый элемент.</returns>
        public object First()
        {
            return _aggregate[0];
        }

        /// <summary>
        /// Следующий элемент коллекции.
        /// </summary>
        /// <returns>Элемент коллекции.</returns>
        public object Next()
        {
            if (_current++ < _aggregate.Count - 1)
            {
                return CurrentItem();
            }

            return null;
        }

        /// <summary>
        /// Текущий элемент коллекции.
        /// </summary>
        /// <returns>Элемент коллекции.</returns>
        public object CurrentItem()
        {
            return _aggregate[_current];
        }

        /// <summary>
        /// Идет выполнение.
        /// </summary>
        /// <returns>
        /// true - если есть элементы в коллекции,
        /// false - если элемент был последним.
        /// </returns>
        public bool IsDone()
        {
            if (_current < _aggregate.Count)
                return true;

            _current = 0;
            return false;
        }
    }
}
