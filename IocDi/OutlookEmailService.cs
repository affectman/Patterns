using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDi
{
    /// <summary>
    /// Сервис outlook для отправки сообщений.
    /// </summary>
    public class OutlookEmailService : IEmailService
    {
        /// <summary>
        /// Отправка сообщения.
        /// </summary>
        /// <param name="emailAddress">Email адрес.</param>
        /// <param name="message">Текст сообщения.</param>
        public void SendMail(string emailAddress, string message)
        {
            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(emailAddress));
            }
                
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(message));
            }
                
            Console.WriteLine("Сообщение отправлено с помощью Outlook");
        }
    }
}
