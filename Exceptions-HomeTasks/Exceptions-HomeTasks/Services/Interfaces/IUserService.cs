using Exceptions_HomeTasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_HomeTasks.Services.Interfaces
{
    internal interface IUserService
    {
        public  User[] GetAll();
        
        public string Login(User[]users,string username,string password);

        public string Login(User[] users, string email, string password,bool a);
    }
}
