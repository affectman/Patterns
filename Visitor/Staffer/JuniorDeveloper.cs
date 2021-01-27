using Visitor.Staff;

namespace Visitor.Staffer
{
    /// <summary>
    /// Младший разработчик.
    /// </summary>
    public class JuniorDeveloper : Employee
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public JuniorDeveloper()
            : base("Джун", 45000, 15)
        {
        }
    }
}
