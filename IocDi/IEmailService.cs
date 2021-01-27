using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDi
{
    /// <summary>
    /// Интерфейс сервиса для отправки сообщений.
    /// </summary>
    public interface IEmailService
    {
        /// <summary>
        /// Отправка сообщения.
        /// </summary>
        /// <param name="emailAddress">Email адрес.</param>
        /// <param name="message">Текст сообщения.</param>
        void SendMail(string emailAddress, string message);
    }
}
