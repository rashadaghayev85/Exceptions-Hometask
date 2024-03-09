using Exceptions_HomeTasks.Helpers.Exceptions;
using Exceptions_HomeTasks.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_HomeTasks.Services
{
    internal class MathService:IMathService
    {
        public string Factorial(int? number)
        {
            try
            {
                int factorial = 1;
                if (number < 0)
                {
                    throw new CustomNegativeNumberException("Faktorial axtarilan eden menfi ola bilmez");
                }
                if (number == 0)
                {
                    factorial = 1;
                }

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                return factorial.ToString();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
