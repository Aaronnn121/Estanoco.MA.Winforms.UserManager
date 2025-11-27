using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estanoco.MA.Winforms.UserManager
{
    public class User
    {
        public User(string fullname, string username, string password) 
        { 
            this.Fullname = fullname;
            this.Username = username;
            this.Password = password;
        }
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }

    }
}
