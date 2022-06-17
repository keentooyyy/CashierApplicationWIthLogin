using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    abstract class UserAccount
    {
        private String full_name;
        protected String user_name;
        protected String user_password;

        public UserAccount(String name, String uName, String password)
        {
            this.full_name = "Dan Fred";
            this.user_name = "user";
            this.user_password = "123";
        }

        public abstract bool validateLogin(String uName, String Password);

        public string getFullName()
        {
            return full_name;
        }
    }
}
