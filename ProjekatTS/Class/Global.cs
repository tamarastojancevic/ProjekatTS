using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTS.Class
{
    class Global
    {

        public static string username;
        public static string password;
        public static string pib;
        public static string adresa;
        public static string fullName;
        public static IEnumerable<User> Users { get; internal set; }


        public static DataSet DSglobal { get; internal set; }



    }
}
