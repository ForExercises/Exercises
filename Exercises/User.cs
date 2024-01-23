using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public  class User
    {
        public  int userid { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public User(int UserID ,string username,string password)
        {
            this.userid = UserID;
            Username= username;
            Password= password;
            if (checkerUser()) throw new UserNameException();
            if (checkpass()) throw new InvalidPasswordException();
        }
        private  bool checkerUser()
        {
            if(!Username.Equals(Password))
            {
                return false;
            }
            return true;
        }
        private bool checkpass()
        {
            return Password.Length < 8;
        }
    }
}
