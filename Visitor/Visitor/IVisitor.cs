using Visitor.Staff;

namespace Visitor.Visitor
{
    /// <summary>
    /// Интерфейс посетителя.
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Метод для различных операций для посетителя.
        /// </summary>
        /// <param name="element"> Элемент(В нашем  случае посетитель). </param>
        void Visit(Element element);
    }
}