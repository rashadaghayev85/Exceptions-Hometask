using Exceptions_HomeTasks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_HomeTasks.Controllers
{
    internal class MathController
    {
        private MathService _mathService;
        public MathController()
        {
            _mathService=new MathService();
        }
        public void Factorial()
        {
            label: Console.WriteLine("factorialini axtardiginiz ededi daxil edin:");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine( "Cavab:"+_mathService.Factorial(number));
            goto label;
        }
    }
}
