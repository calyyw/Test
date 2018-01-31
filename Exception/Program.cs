using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception
{
    /*
    class DivNumbers
    {
        int result;
        DivNumbers()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            //catch (SystemException e)
            //{
            //    Console.WriteLine("Exception caught!");
            //}
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }

        }
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
    */

    class TestTemperature
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
       
            //temp.showTemp();
            try
            {
                //temp.showTemp();//抛出异常代码
                throw (new TempIsZeroException("抛出异常"));
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
                //throw e;
            }
            Console.ReadKey();
        }
    }
}
public class TempIsZeroException : ApplicationException
{
    public TempIsZeroException(string message)
        : base(message)
    {
    }
}
public class Temperature
{
    int temperature = 0;
    public void showTemp()
    {
        if (temperature == 0)
        {
            throw (new TempIsZeroException("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature: {0}", temperature);
        }
    }
}