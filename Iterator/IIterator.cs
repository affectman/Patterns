namespace Iterator
{
    /// <summary>
    /// Итератор для перебора коллекции.
    /// </summary>
    /// <typeparam name="T">Тип элементов коллекции.</typeparam>
    public interface IIterator<T>
    {
        /// <summary>
        /// Получить первый элемент.
        /// </summary>
        /// <returns>Первый элемент.</returns>
        object First();

        /// <summary>
        /// Следующий элемент коллекции.
        /// </summary>
        /// <returns>Элемент коллекции.</returns>
        object Next();

        /// <summary>
        /// Идет выполнение.
        /// </summary>
        /// <returns>
        /// true - если есть элементы в коллекции,
        /// false - если элемент был последним.
        /// </returns>
        bool IsDone();

        /// <summary>
        /// Текущий элемент коллекции.
        /// </summary>
        /// <returns>Элемент коллекции.</returns>
        object CurrentItem();
    }
}
