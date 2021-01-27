using Visitor.Visitor;

namespace Visitor.Staff
{
    /// <summary>
    /// Иерархия элементов.
    /// </summary>
    public abstract class Element
    {
        /// <summary>
        /// Метод принятия посетителя.
        /// </summary>
        /// <param name="visitor"> Посетитель. </param>
        public abstract void Accept(IVisitor visitor);
    }
}
