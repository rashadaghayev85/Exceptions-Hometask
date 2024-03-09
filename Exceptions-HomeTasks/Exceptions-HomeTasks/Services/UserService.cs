using Exceptions_HomeTasks.Helpers.Exceptions;
using Exceptions_HomeTasks.Models;
using Exceptions_HomeTasks.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_HomeTasks.Services
{
    internal class UserService : IUserService
    {
        public UserService()
        {

        }



        public  User[] GetAll()
        {
            User user1 = new()
            {
                Id = 1,
                Username = "Rashad",
                Email = "rashad@gmail.com",
                Password = "Ordubad123"


            };

            User user2 = new()
            {
                Id = 2,
                Username = "Rufat",

                Email = "rufat@gmail.com",
                Password = "Baki",

            };

            User user3 = new()
            {
                Id = 3,
                Username = "Cavid",

                Email = "cavid@gmail.com",
                Password = "Siyezen"

            };

            User user4 = new()
            {
                Id = 4,
                Username = "Amirastan",

                Email = "Amirastan@gmail.com",
                Password = "Xezer"


            };

            User user5 = new()
            {
                Id = 5,
                Username = "Esgerxan",

                Email = "esgerxan@gmail.com",
                Password = "Berde"


            };

            User user6 = new()
            {
                Id = 6,
                Username = "Behruz",
                Email = "bahruz@gmail.com",
                Password = "Ordubad"


            };

            User user7 = new()
            {
                Id = 7,
                Username = "Rashad",

                Email = "rashad@gmail.com",
                Password = "Ordubad"


            };
            User user8 = new()
            {
                Id = 8,
                Username = "Ismayil",

                Email = "ismayil@gmail.com",
                Password = "Ehmedli"


            };

            User[] users= { user1, user2, user3, user4, user5, user6, user7, user8 };
            return users;
        }

        public string? Login(User[] users, string username, string password)
        {
            try
            {
                if (password.Length < 6)
                {
                    throw new CustomPasswordException("Passwordun simvollarinin sayi 6dan az ola bilmez");
                }
                var result = users.FirstOrDefault(m =>m.Username == username && m.Password == password);
                if (result != null)
                {
                    
                    return "Login succes";
                }
                else
                {
                    throw new CustomUserFalseException("CustomExceptions!User not found");
                }
             

            }

            catch (CustomPasswordException ex)
            {
                return ex.Message;
            }
            catch (CustomUserFalseException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

       

        public string? Login(User[] users, string email, string password,bool a)
        {
            try
            {
                 
                if (password.Length <6)
                {
                    throw new CustomPasswordException("Passwordun simvollarinin sayi 6dan az ola bilmez");
                }
                var result = users.FirstOrDefault(m => m.Email == email && m.Password == password);
                if (result != null)
                {

                    return "Login succes";
                }
                else
                {
                    throw new CustomUserFalseException("CustomExceptions!User not found");
                }


            }

            catch (CustomPasswordException ex)
            {
                return ex.Message;
            }
            catch (CustomUserFalseException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

       
    }

}
