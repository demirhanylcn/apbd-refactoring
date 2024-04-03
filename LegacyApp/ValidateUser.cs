using System;

namespace LegacyApp
{
    public class ValidateUser : IValidateUser
    {
        public bool ValidateUserStatus(User user)
        {
            if (!user.EmailAddress.Contains("@") || !user.EmailAddress.Contains("."))
                return false;

            if (string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName))
                return false;

            int age = DateTime.Now.Year - user.DateOfBirth.Year;
            if (DateTime.Now.Month < user.DateOfBirth.Month || (DateTime.Now.Month == user.DateOfBirth.Month && DateTime.Now.Day < user.DateOfBirth.Day))
                age--;

            if (age < 21)
                return false;

            return true;
        }
    }
}