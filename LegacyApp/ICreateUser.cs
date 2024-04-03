using System;

namespace LegacyApp
{
    public interface ICreateUser
    {
        public User createUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId);
    }
}