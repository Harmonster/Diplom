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
        public static (bool, string) ValidateEmail(string email)
        {
            if (email.Trim() == string.Empty)
            {
                return (false, "Вы не указали адрес электронной почты.");
            }

            Regex mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

            if (!mRegxExpression.IsMatch(email.Trim()))
            {
                return (false, "Неправильный формат адреса электронной почты");
            }

            return (true, string.Empty);
        }
        ///// <summary>
        ///// Валидация адреса электронной почты
        ///// </summary>
        ///// <param name="email">Адрес электронной почты</param>
        ///// <returns>true - валидация пройдена успешно; false - валидация не пройдена</returns>
        //public static bool ValidateEmail(string email)
        //{
        //    if (email.Trim() != string.Empty)
        //    {
        //        Regex mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
        //        if (!mRegxExpression.IsMatch(email.Trim()))
        //        {
        //            MessageBox.Show("Неправильный формат адреса электронной почты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        else
        //            return true;
        //    }
        //    return false;
        //}
        /// <summary>
        /// Валидация пароля
        /// </summary>
        /// <param name="password">Пароль</param>
        /// <returns>true - валидация пройдена успешно; false - валидация не пройдена</returns>
        //public static bool ValidatePassword(string password)
        //{
        //    if (password.Any(Char.IsWhiteSpace))
        //    {
        //        MessageBox.Show("Пароль не должен содержать пробел. Повторите ввод.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return false;
        //    }
        //    else if (!password.Any(Char.IsNumber))
        //    {
        //        MessageBox.Show("Пароль должен содержать как минимум одну цифру. Повторите ввод.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return false;
        //    }
        //    else if (!password.Any(Char.IsUpper))
        //    {
        //        MessageBox.Show("Пароль должен содержать как минимум одну заглавную букву. Повторите ввод.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return false;
        //    }
        //    else if (!password.Any(Char.IsLower))
        //    {
        //        MessageBox.Show("Пароль должен содержать как минимум одну букву нижнего регистра. Повторите ввод.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return false;
        //    }
        //    else if (password.Length < 6)
        //    {
        //        MessageBox.Show("Длина пароля должна составлять как минимум 6 символов. Повторите ввод.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return false;
        //    }
        //    return true;
        //}

        public static (bool, string) ValidatePassword(string password)
        {
            if (password.Any(Char.IsWhiteSpace))
            {
                return (false, "Пароль не должен содержать пробел. Повторите ввод.");
            }
            else if (!password.Any(Char.IsNumber))
            {
                return (false, "Пароль должен содержать как минимум одну цифру. Повторите ввод.");
            }
            else if (!password.Any(Char.IsUpper))
            {
                return (false, "Пароль должен содержать как минимум одну заглавную букву. Повторите ввод.");
            }
            else if (!password.Any(Char.IsLower))
            {
                return (false, "Пароль должен содержать как минимум одну букву нижнего регистра. Повторите ввод.");
            }
            else if (password.Length < 6)
            {
                return (false, "Длина пароля должна составлять как минимум 6 символов. Повторите ввод.");
            }
            return (true, string.Empty);
        }


    }
}
