﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTS.Class
{
    class User
    {

        public User() { }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
      
        }

        public string Username { get; set; }
        public string Password { get; set; }



    }
}