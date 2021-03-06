﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDi
{
    /// <summary>
    /// Сервис google для отправки сообщений.
    /// </summary>
    public class GmailService : IEmailService
    {
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
            Console.WriteLine("Сообщение отправлено с помощью Gmail");
        }
    }
}
