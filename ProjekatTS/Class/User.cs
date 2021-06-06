using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTS.Class
{
    class User
    {

        private string pib;
        private string fullName;
        private string adresa;

        public User() { }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Pib = pib;
            Adresa = adresa;

        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Pib { get; set; }
        public string Adresa { get; set; }



    }
}