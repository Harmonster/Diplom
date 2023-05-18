using System;
using System.Linq;

namespace Diplom.Classes
{
    public static class PasswordGenerator
    {
        static Random random = new Random();

        public static string GeneratePassword(int length)
        {
            string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string symbols = "!@#$%^&*()-=_+[]{}|;:,.<>?";

            // Генерируем минимум 1 цифру, 1 букву маленького регистра, 1 букву большого регистра
            string password = GetRandomChar(uppercaseLetters) + GetRandomChar(lowercaseLetters) + GetRandomChar(digits).ToString();

            for (int i = 0; i < length - 3; i++)
            {
                string chars = uppercaseLetters + lowercaseLetters + digits + symbols;
                password += GetRandomChar(chars);
            }

            // Перемешиваем
            password = new string(password.ToCharArray().OrderBy(x => random.Next()).ToArray());

            return password;
        }

        private static char GetRandomChar(string chars)
        {
            int index = random.Next(chars.Length);
            return chars[index];
        }
    }
}
