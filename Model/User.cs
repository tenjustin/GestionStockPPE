using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Model
{
    internal class User
    {
        private int id { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        private Role role { get; set; }

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
