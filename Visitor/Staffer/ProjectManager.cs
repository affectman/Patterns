using Visitor.Staff;

namespace Visitor.Staffer
{
    /// <summary>
    /// Руководитель проекта.
    /// </summary>
    public class ProjectManager : Employee

    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public ProjectManager()
            : base("РП", 120000, 30)
        {
        }
    }
}
