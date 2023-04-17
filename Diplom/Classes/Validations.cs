using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Diplom.Classes
{
    public static class Validations
    {
        /// <summary>
        /// Валидация адреса электронной почты
        /// </summary>
        /// <param name="email">Адрес электронной почты</param>
        /// <returns>true - валидация пройдена успешно; false - валидация не пройдена</returns>
        public static bool ValidateEmail(string email)
        {
            if (email.Trim() != string.Empty)
            {
                Regex mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!mRegxExpression.IsMatch(email.Trim()))
                {
                    MessageBox.Show("Неправильный формат адреса электронной почты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                    return true;
            }

            MessageBox.Show("Вы не ввели логин. Пожалуйста повторите ввод.", "Ошибка", MessageBoxButtons.OK);
            return false;
        }



    }
}
