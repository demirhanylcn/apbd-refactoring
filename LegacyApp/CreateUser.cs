using System;

namespace LegacyApp
{
    public class CreateUser : ICreateUser
    {
        public User createUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        {
            
            var clientRepository = new ClientRepository();
            var client = clientRepository.GetById(clientId);
            
            var user = new User
            {
                Client = client,
                DateOfBirth = dateOfBirth,
                EmailAddress = email,
                FirstName = firstName,
                LastName = lastName
            };
            return user;
        }
    }
}