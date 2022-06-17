using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    internal class Cashier : UserAccount
    {
        private String department;
         

        public Cashier(String name, String department, String uName, String password) : base(name, uName, password)
        {
           this.department = "IT";
           

        }
        public override bool validateLogin(String uName, String passsword)
        {
            if (uName.Equals(user_name) && passsword.Equals(user_password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getDepartment()
        {
            return department;
        }

    }
}
