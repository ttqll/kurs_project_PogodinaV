using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_project_PogodinaV
{
    public class User
    {
        private string userName;
        private string nickName;
        private string password;

        public void SetNickName(string nickName)
        {
            this.nickName = nickName;
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public void SetPassword(string password) 
        {
            this.password = password;
        }

        public string RemindPassword()
        {
            return this.password;
        }

        public void DeleteAccount()
        {

        }
        public void ExitAccount()
        {

        }
        public void ChangeUser()
        {

        }
        public void ChangePhoto()
        {

        }
        public void ResetProgress()
        {

        }
    }
}
