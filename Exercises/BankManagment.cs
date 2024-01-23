using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class BankManagment
    {
        public List<User> _Users { get; set; } = new List<User>()
        {
            new User(1,"Guga1234","GugaGuga"),
            new User(2,"Guga12345","GugaGuga"),
            new User(3,"Guga12","GugaGuga"),
            new User(4,"Guga12","GugaGuga")
        };

        public List<Bank> _listofaccounts = new List<Bank>()
        {
            new Bank(1,500),
            new Bank(2,800),
            new Bank(3,345),
        };

        private  User SignIn(string UserName,string Password)
        {
            foreach (var item in _Users)
            {
                if (item.Username.Equals(UserName) && item.Password.Equals(Password))
                    return item;
            }
            return null;
        }

        public bool Transfer(string username,string password,int touserid, double  howmuch)
        {
           var sender= SignIn(username, password);
            if (sender == null)
                throw new NoSuchUserExistException();
            var senderbank = _listofaccounts.Where(io => io.UserID == sender.userid).FirstOrDefault();
            if (senderbank.Balance < howmuch) throw new NoEnoughtBalanceException();
            senderbank.Balance -= howmuch;
            var recieverbank = _listofaccounts.Where(io => io.UserID == touserid).FirstOrDefault();
            recieverbank.Balance += howmuch;
            return true;

        }
    }
}
