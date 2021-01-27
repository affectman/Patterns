using System.Collections.Generic;

namespace Iterator
{
    /// <summary>
    /// Конкретная коллекция.
    /// </summary>
    /// <typeparam name="T">Тип элементов коллекции.</typeparam>
    public class ConcreteAggregate<T> : IAggregate<T>
    {
        /// <summary>
        /// Список элементов.
        /// </summary>
        private List<T> _collection = new List<T>();

        /// <summary>
        /// Создать итератор.
        /// </summary>
        /// <returns>Итератор.</returns>
        public IIterator<T> CreateIterator()
        {
            return new Iterator<T>(this);
        }

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count => _collection.Count;

        /// <summary>
        /// Элемент в списке.
        /// </summary>
        /// <param name="index">Индекс.</param>
        public T this[int index] { get => _collection[index]; set => _collection.Insert(index, value); }
    }
}
