using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Estanoco.MA.Winforms.UserManager
{
    public class UserRepository
    {
        private readonly ISQLiteConnection connection;
        public UserRepository()
        {
            connection = new SQLiteConnection("userdate.db");
        }
     
        public bool Add(User user)
        {
            return true;
        }
        public List<User> GetAll()
            {
            return new List<User>();
            }
    public User Get(int id)
        {
            return new User("DummyFullname", "DummyUsername", "DummyPassword");
        }

    }
}
