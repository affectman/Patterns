using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// Посредник для связи.
    /// </summary>
    public interface IMediator
    {
        /// <summary>
        /// Отправить сообщение.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="salesManager">Экземпляр менеджера по продажам.</param>
        void SendMessage(string message, SalesManager salesManager);
    }
}
