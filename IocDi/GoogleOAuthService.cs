using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDi
{
    /// <summary>
    /// Сервис google аутентификации.
    /// </summary>
    public class GoogleOAuthService
    {
        /// <summary>
        /// Регистрация пользователя.
        /// </summary>
        /// <param name="emailAddress">Email адрес.</param>
        /// <param name="password">Пароль.</param>
        /// <returns></returns>
        public string RegisterUser(string emailAddress, string password)
        {
            if (emailAddress == null)
            {
                throw new ArgumentNullException(nameof(emailAddress));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }
            Console.WriteLine("Зарегистрирован новый пользователь!");
            return "success";
        }
    }
}
