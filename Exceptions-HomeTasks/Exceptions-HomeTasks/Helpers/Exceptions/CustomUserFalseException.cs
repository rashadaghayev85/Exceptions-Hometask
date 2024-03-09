using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_HomeTasks.Helpers.Exceptions
{
    internal class CustomUserFalseException:Exception
    {
        public CustomUserFalseException(string msj):base(msj)
        {
            
        }
    }
}
