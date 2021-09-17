using System;

namespace Bank1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            User user = new User("kinia","abc");
            User user1 = new User("Piotr","abc");
            User user2 = new User("Darek","abc");
            User user3 = new User("Ktokolwiek","abc");

            Admin admin = new Admin();


            user.DepositMoney(500);
            user2.DepositMoney(1500);
            user3.DepositMoney(2500);

            admin.CreateAccount(user);
            admin.CreateAccount(user2);
            admin.CreateAccount(user3);

            admin.CheckAccountHistory(user);
            admin.CheckAccountHistory(user2);
            admin.CheckAccountHistory(user3);
            admin.BlockAccount(user);
            admin.DeleteAccount(user1);

            

        }
    }
}
