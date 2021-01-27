using Visitor.Staff;

namespace Visitor.Staffer
{
    /// <summary>
    /// Руководитель разработки.
    /// </summary>
    public class TeamLead : Employee
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        public TeamLead()
            : base("TeamLead", 100000, 15)
        {
        }
    }
}
