using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var manage = new BankManagment();
                manage.Transfer("guga123", "gugaguga", 2, 7889);
            }
            catch (Exception exp)
            {

                Console.WriteLine( exp);
            }
        }
    }
}
