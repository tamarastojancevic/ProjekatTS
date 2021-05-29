using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTS.Class
{
    class Global
    {

        public static string username;
        public static string password;

        public static IEnumerable<User> Users { get; internal set; }
    }
}
