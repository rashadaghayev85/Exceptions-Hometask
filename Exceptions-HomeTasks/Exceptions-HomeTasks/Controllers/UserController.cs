using Exceptions_HomeTasks.Models;
using Exceptions_HomeTasks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_HomeTasks.Controllers
{
    internal class UserController
    {
        UserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }
        public void GetAll()
        {
            User[] result= _userService.GetAll();
            foreach (User user in result)
            {
                Console.WriteLine(user.Username);
            }
           
        }
        public void Login()
        {
            Console.WriteLine("1----Login for Username\n2------Login for Email");
            int num=int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("enter username");
                string username = Console.ReadLine();
                Console.WriteLine("enter password");
                string password = Console.ReadLine();
               
                var result = _userService.Login(_userService.GetAll(), username, password);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("enter email");
                string email = Console.ReadLine();
                Console.WriteLine("enter password");
                string password = Console.ReadLine();
                bool a = true;
                var result = _userService.Login(_userService.GetAll(), email, password,a );
                Console.WriteLine(result);
            }
            
            
            

            
        }
    }
}
