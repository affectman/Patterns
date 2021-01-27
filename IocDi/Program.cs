using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDi
{
    class Program
    {
        static void Main(string[] args)
        {
            OutlookEmailService outlookEmailService = new OutlookEmailService();
            UserLogic userLogic = new UserLogic(outlookEmailService);
            userLogic.Register("email", "password", outlookEmailService);
            Console.ReadLine();
        }
    }
}
