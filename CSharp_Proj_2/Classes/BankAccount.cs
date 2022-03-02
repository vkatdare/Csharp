using System;
namespace CSharp_Proj_2.Classes
{
    public class BankAccount
     
    {
        private string owner;
        private float balance;

        public float Balance
        {
            get
            {
                return balance;
            }

            private set {
                if (value >= 0)
                {
                    balance = value;

                }
                else
                {
                    balance = 0;
                }

            }

        }


        public BankAccount(string owner, float balance)
        {
            this.owner = owner;
            this.Balance = balance;
        }

        public virtual  float AddBalance(float newBalance)
        {
            Balance = balance + newBalance;

            return Balance;
        }

        public virtual float AddBalance(float newBalance, bool balanceCanBeNeg)
        {
            if (balanceCanBeNeg)
            {
                balance = balance + newBalance;
            }
            else
            {

                Balance = Balance + newBalance;
            }

            return Balance;
        }
    }

    public class ChildBankAccount : BankAccount
    {
        public string Parent { get; set; }

        public ChildBankAccount(string owner, float balance, string parent) : base(owner, balance)
        {
            Parent = parent;
        }

        public override float AddBalance(float newBalance)
        {
            if (newBalance >= -10)
                return base.AddBalance(newBalance);
            else
                return Balance;
        }

        public override float AddBalance(float newBalance, bool balanceCanBeNeg)
        {
            if (newBalance >= -10)
                return base.AddBalance(newBalance, balanceCanBeNeg);
            else
                return Balance;
        }
    }
}
