using System;

namespace LegacyApp
{
    public class UserService
    {
        private readonly ICreateUser _createUser;
        private readonly IValidateUser _validateUser;
        private readonly ICreditService _creditService;
        
        public UserService()
        {
            _createUser = new CreateUser();
            _validateUser = new ValidateUser();
            _creditService = new CreditService();
            
        }
        public bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        {
            
            var user = _createUser.createUser(firstName, lastName, email, dateOfBirth, clientId);
            if (!_validateUser.ValidateUserStatus(user)) return false;
            
            _creditService.setCreditLimit(user);
            
            if (user.HasCreditLimit && user.CreditLimit < 500) return false;

            UserDataAccess.AddUser(user);
            return true;
        }
    }
}
