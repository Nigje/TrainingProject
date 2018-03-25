using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acount=new Account("Nigje");
            acount.Despose(10);
            acount.Despose(100);
            acount.Withdraw(1000);
            acount.Withdraw(2000);
            acount.Withdraw(2000);
            acount.Withdraw(2000);
        }
    }

    public abstract class State
    {
        protected State(State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
        }

        protected State()
        {
        }

        private Account account { get; set; }
        private decimal balance { get; set; }


        // Properties

        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public abstract void Despose(decimal amount);
        public abstract void Withdraw(decimal amount);

        public virtual void CheckState()
        {
            Console.WriteLine("Balance: "+Balance);
            if (Balance <= 0)
                Account.State = new RedState(this);
            else if (Balance > 0 && Balance <= 1000)
            {
                account.State = new SilverState(this);
            }
            else
            {
                account.State = new GoldState(this);
            }
        }
    }
    //************************************************************************************
    public class RedState : State
    {

        public RedState(State state) : base(state)
        {
        }

        public override void Despose(decimal amount)
        {
            Console.WriteLine("Disposed: "+this.GetType().ToString());
            Balance -= amount;
            CheckState();
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("Withdraw: " + this.GetType().ToString());
            Balance += amount;
            CheckState();
        }
    }
    //**************************************************************************
    public class SilverState : State
    {
        public SilverState(State state) : base(state)
        {
        }
        public override void Despose(decimal amount)
        {

            Console.WriteLine("Disposed: "+ this.GetType().ToString());
            Balance -= amount;
            CheckState();
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("Withdraw: "+ this.GetType().ToString());
            Balance += amount;
            CheckState();
            
        }
    }

    //**************************************************************************
    public class GoldState : State
    {
        public GoldState(State state) : base(state)
        {
        }

        public override void Despose(decimal amount)
        {
            Console.WriteLine("Disposed: "+ this.GetType().ToString());
            Balance -= amount;
            CheckState();
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("Withdraw: "+ this.GetType().ToString());
            Balance += amount;
            CheckState();
        }
    }
    //**************************************************************************
    public class BaseState :State
    {
        public BaseState()
        {
        }

        public BaseState(State state):base(state)
        {
        }

        public BaseState(decimal balance, Account account):this(new BaseState() {Balance = balance,Account = account})
        {
            
        }


        public override void Despose(decimal amount)
        {
            Console.WriteLine("Despose: " + this.GetType().ToString());
            Balance -= amount;
            CheckState();
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("Withdraw: " + this.GetType().ToString());
            Balance += amount;
            CheckState();
        }
    }
    //**************************************************************************
    public class Account
    {
        public Account(string name)
        {
            Name = name;
            State = new BaseState(0, this);
        }
        public string Name { get; set; }
        public State State { get; set; }

        public void Despose(decimal amount)
        {
            State.Despose(amount);
        }
        public void Withdraw(decimal amount)
        {
            State.Withdraw(amount);
        }
    }
}
