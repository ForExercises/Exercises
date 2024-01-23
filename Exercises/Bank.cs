using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Bank
    {
        public  int UserID { get; set; }

        public double Balance  { get; set; }

        public Bank(int userid,double Balance)
        {
            this.UserID = userid;
            this.Balance = Balance;
            if (!checkbalance()) throw new BankRupException();
        }

        private bool checkbalance()
        {
            if(Balance<=0) return false;

            return true;
        }
    }
}
