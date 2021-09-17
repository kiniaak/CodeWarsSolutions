using System.Collections.Generic;

namespace Bank1
{
     abstract class Bank
    {
        List<User> usersList = new List<User>();
        List<User> blackList = new List<User>();

        public void CreateAccount(User user)
        {
            usersList.Add(user);
        }
        public void DepositMoney(User user,float money)
        {

        }
        public void CheckAccountHistory(User user)
        {
           
        }
        public bool BlockAccount(User user)

        {
            return false;
        }

        public void DeleteAccount(User user)
        {
            usersList.Remove(user);
        }

        public void CheckCredit(User user)
        {
            blackList.Add(user);
        }
    }
}
