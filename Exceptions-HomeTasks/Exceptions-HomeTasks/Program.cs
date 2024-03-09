

using Exceptions_HomeTasks.Controllers;
using Exceptions_HomeTasks.Helpers.Exceptions;
using System.Runtime.InteropServices;
#region Practice
void Calculate()
{
    bool isCorrect = true;
    try
    {
        int a = 5;
        int b = 0;
        // var result = a / b;
        //Console.WriteLine(result);
        //if (b == 0)
        //{
        //    return;
        //}
        var result = a / b;
        Console.WriteLine(result);


        //int[] arr = { 1, 2, 3 };
        //arr[5] = 100;
    }
    //catch (DivideByZeroException ex)
    //{

    //       Console.WriteLine(ex.Message);
    //   }
    //   catch (IndexOutOfRangeException ex)
    //   {

    //       Console.WriteLine(ex.Message);
    //   }
    catch (Exception ex)
    {
        isCorrect = false;

    }
    finally
    {
        SendMessage(isCorrect);
    }
}
//Calculate(); 

void SendMessage(bool isCorrect)
{

    if (isCorrect)
    {
        Console.WriteLine("succesfully");
    }
    else
    {
        Console.WriteLine("failed");
    }
}


string GetById(int? id)
{
    try
    {
        if (id == null)
        {
            //throw new ArgumentNullException("id");
            //throw new ArgumentNullException(nameof(id),"Salam ,menem exception");
            //ArgumentNullException.ThrowIfNull(id);
            throw new CustomArgumentNullException("Argument cAnnot be null");
        }
        return "Salam";
    }
    catch (Exception ex)
    {

        return  ex.Message;
    }
}
var result=GetById(null);
//Console.WriteLine(result);
#endregion
#region Hometask
//2. Ededin faktorilalini tapan method yazmaq. Eger menfi eded daxil edilibse custom exception cixarsin.


MathController  mathController = new MathController();
//mathController.Factorial();



//3. Login ucun custom exception yazib isdifade etmek. Eger email ve yaxud password sehvdirse custom exception istifade edin. Models, Services, Controller folderleriniz olacaq. Service mentiqi ile yazirsiz. 
//4. Bir custom exception classi yaradin. Login olan zaman passwordun simvollarinin sayi 6-dan kicikdirse exception cixarsin. 
UserController userController = new UserController();
//userController.GetAll();
//userController.Login();(HEM 3CU TASKI hem 4cu taski bir yerde yazmisam)



#endregion







