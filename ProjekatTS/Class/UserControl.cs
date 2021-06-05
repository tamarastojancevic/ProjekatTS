using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTS.Class
{
    class UserControl
    {
        private readonly UserService userService;


        public UserControl(UserService userService)
        {
            userService = userService;
        }
        public IEnumerable<User> GetAll() => userService.GetAll();
        public User Get(long id) => userService.Get(id);
        public User Create(User user) => userService.Create(user);
        public void Update(User user) => userService.Update(user);
        public void Delete(User user) => userService.Delete(user);
        public User LogIn(User userLogIn)
        {
            return userService.LogIn(userLogIn);
        }
        public bool CheckIfUserNameUnique(string fullName)
        {
            return userService.CheckIfUserNameUnique(fullName);
        }

        public IEnumerable<User> SearchUsers(string searchParam)
        {
            return userService.SearchBy(searchParam.ToUpper());
        }
    }
}
