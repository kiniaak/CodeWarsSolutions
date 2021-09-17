using System;

namespace Bank1
{
    class User
    {

        private string login;
        private string password;
        private float balance=0;

        public User(string login,string password)
        {
            this.login = login;
            this.password = password;
        }

        public void DepositMoney(float money)
        {
            balance += money;
            Console.WriteLine($"Deposited {money}, your balance is now {balance}");
        }
        public void TakeMoney(float money)
        {
            balance -= money;
        }

        public void CheckHistory()
        {
            Console.WriteLine($"{login} , {password}, {balance}");

        }
        public void Summary(float credit)
        {
            Console.WriteLine($"Summary:{ balance}");
            Console.WriteLine($"Credit to pay:{credit}");
            
           
        }
        public void TakeCredit(float credit,float money)
        {
            credit += money;

        }
        public void PayCredit(float credit,float money)
        {
            credit -= money;
        }
    }
}
