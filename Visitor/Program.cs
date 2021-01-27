using System;
using Visitor.Staff;
using Visitor.Staffer;
using Visitor.Visitor;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new Employees();
            e.AttachEmployee(new JuniorDeveloper());
            e.AttachEmployee(new TeamLead());
            e.AttachEmployee(new ProjectManager());

            e.AcceptEmployees(new SalaryVisitor());
            e.AcceptEmployees(new VacationVisitor());

            Console.ReadKey();
        }
    }
}
