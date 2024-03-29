using System;

namespace LegacyApp
{
    public class ValidateUser : IValidateUser
    {
        public bool ValidateUserStatus(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            if (!email.Contains("@") || !email.Contains("."))
                return false;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                return false;

            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.Month < dateOfBirth.Month || (DateTime.Now.Month == dateOfBirth.Month && DateTime.Now.Day < dateOfBirth.Day))
                age--;

            if (age < 21)
                return false;

            return true;
        }
    }
}