using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Model
{
    internal class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Role role { get; set; }

        public User(string username, string password, Role role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public User(int id, string username, string password, Role role)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
        }
    }
}
