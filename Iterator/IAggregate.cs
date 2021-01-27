namespace Iterator
{
    /// <summary>
    /// Перечисляемая коллекция.
    /// </summary>
    /// <typeparam name="T">Тип элементов коллекции.</typeparam>
    public interface IAggregate<T>
    {
        /// <summary>
        /// Создать итератор.
        /// </summary>
        /// <returns>Итератор.</returns>
        IIterator<T> CreateIterator();

        /// <summary>
        /// Количество элементов.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Элемент в списке.
        /// </summary>
        /// <param name="index">Индекс.</param>
        T this[int index] { get; set; }
    }
}
