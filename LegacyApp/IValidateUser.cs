using System;

namespace LegacyApp
{
    public interface IValidateUser
    {
            bool ValidateUserStatus(string firstName, string lastName, string email, DateTime dateOfBirth);

    }
}