using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDi
{
    /// <summary>
    /// Пользовательская логика.
    /// </summary>
    public class UserLogic
    {
        private GoogleOAuthService _authService;
        private IEmailService _emailService;

        public UserLogic(IEmailService emailService)
        {
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            _authService = new GoogleOAuthService();
            
        }

        /// <summary>
        /// Регистрация.
        /// </summary>
        /// <param name="emailAddress"> Email адрес.</param>
        /// <param name="password"> Пароль.</param>
        /// <param name="emailService">Сервис почтовых сообщений.</param>
        public void Register(string emailAddress, string password, IEmailService emailService)
        {
            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(emailAddress));
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(password));
            }

            if (emailService == null)
            {
                throw new ArgumentNullException(nameof(emailService));
            }

            var authResult = _authService.RegisterUser(emailAddress, password);
            emailService.SendMail(emailAddress, authResult);
        }
    }
}
