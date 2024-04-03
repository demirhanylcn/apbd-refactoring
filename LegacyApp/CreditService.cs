namespace LegacyApp
{
    public class CreditService : ICreditService
    {
        public void setCreditLimit(User user)
        {
            if (user.Client == "VeryImportantClient")
            {
                user.HasCreditLimit = false;
            }
            else if (user.Client == "ImportantClient")
            {
                using (var userCreditService = new UserCreditService())
                {
                    int creditLimit = userCreditService.GetCreditLimit(user.LastName, user.DateOfBirth);
                    creditLimit = creditLimit * 2;
                    user.CreditLimit = creditLimit;
                }
            }
            else
            {
                user.HasCreditLimit = true;
                using (var userCreditService = new UserCreditService())
                {
                    int creditLimit = userCreditService.GetCreditLimit(user.LastName, user.DateOfBirth);
                    user.CreditLimit = creditLimit;
                }
            }

            
        }
    }
}